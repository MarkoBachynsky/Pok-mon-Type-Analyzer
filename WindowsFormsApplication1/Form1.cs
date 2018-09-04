using PokemonTypeAnalyzer;
using PokemonTypeAnalyzer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace PokemonTypeAnalyzer
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
            readTypeChart();
            path = Directory.GetCurrentDirectory() + @"\Font.bin";
            if (File.Exists(@path))
            {
                string font = DeSerializeObject<string>(@path);
                updateFonts(font);
            }
            
        }

        public void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(fileName);
                    stream.Close();
                }
            }
            catch (Exception ex) { }
        }

        public T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            T objectOut = default(T);

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader);
                        reader.Close();
                    }

                    read.Close();
                }
            }
            catch (Exception ex) { }
            return objectOut;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void pbOne_Click(object sender, EventArgs e)
        {
            if (Globals.getp1() == false) return;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.poke_beep);
            audio.Play();
            pb1.Image = null;
            Globals.setT1(null);
            Globals.setp1(false);
            removeDataFromTables();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Globals.getp2() == false) return;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.poke_beep);
            audio.Play();
            pb2.Image = null;
            Globals.setT2(null);
            Globals.setp2(false);
            removeDataFromTables();
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Image ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        public unsafe static bool AreEqual(Image i1, Image i2)
        {
            Bitmap b1, b2;
            try
            {
                b1 = new Bitmap(i1);
                b2 = new Bitmap(i2);
            }
            catch (Exception e)
            {
                var st = new StackTrace(e, true); // Get stack trace for the exception with source file information
                var frame = st.GetFrame(0); // Get the top stack frame
                var line = frame.GetFileLineNumber(); // Get the line number from the stack frame
                Debug.WriteLine(line + " IS UNEQUAL METHOD");
                return false;
            }

            if (b1.Size != b2.Size)
            {
                return false;
            }

            if (b1.PixelFormat != b2.PixelFormat)
            {
                return false;
            }

            if (b1.PixelFormat != PixelFormat.Format32bppArgb)
            {
                return false;
            }

            Rectangle rect = new Rectangle(0, 0, b1.Width, b1.Height);
            BitmapData data1
                = b1.LockBits(rect, ImageLockMode.ReadOnly, b1.PixelFormat);
            BitmapData data2
                = b2.LockBits(rect, ImageLockMode.ReadOnly, b1.PixelFormat);

            int* p1 = (int*)data1.Scan0;
            int* p2 = (int*)data2.Scan0;
            int byteCount = b1.Height * data1.Stride / 4; //only Format32bppArgb 

            bool result = true;
            for (int i = 0; i < byteCount; ++i)
            {
                if (*p1++ != *p2++)
                {
                    result = false;
                    break;
                }
            }

            b1.UnlockBits(data1);
            b2.UnlockBits(data2);

            return result;
        }
        private void readTypeChart()
        {
            Types[] listOfTypes = new Types[18];
            List<Image>[] Image = new List<Image>[4];
            List<double>[] Value = new List<double>[4];
            int counter = 0;
            string line, result = "";
            path = @Directory.GetCurrentDirectory() + @"\typechart.txt";
            Dictionary<string, Image> imageDict = Globals.getImageDict();
            StreamReader file = new StreamReader(path);
            while ((line = file.ReadLine()) != null)
            {
                result += line;
                counter++;
            }
            string[] lines = File.ReadAllLines(path), attackDefense = null, commaSplit = null, colenSplit = null;
            string[] types = new string[18];
            string type = null;
            for (int i = 0; i < lines.Length; i++)
            {
                Image[0] = new List<Image>();
                Image[1] = new List<Image>();
                Image[2] = new List<Image>();
                Image[3] = new List<Image>();
                Value[0] = new List<double>();
                Value[1] = new List<double>();
                Value[2] = new List<double>();
                Value[3] = new List<double>();
                type = lines[i].Substring(0, lines[i].IndexOf(" ")); // Bug\b
                lines[i] = lines[i].Substring(lines[i].IndexOf(" ") + 1);
                attackDefense = lines[i].Split('-'); // Dark:2 >-< Fire:2
                commaSplit = attackDefense[0].Split(','); // Fire:.5 >,< Grass:2 // Attack
                for (int j = 0; j < commaSplit.Length; j++)
                {
                    colenSplit = commaSplit[j].Split(':'); // Fire >:< .5
                    if (colenSplit[1].Equals("0")) // Does no effect
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[1].Add(entry.Value);
                                break;
                            }
                        }
                        Value[1].Add(Double.Parse(colenSplit[1]));
                    }
                    else if (colenSplit[1].Equals(".5")) // Not effective
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[1].Add(entry.Value);
                                break;
                            }
                        }
                        Value[1].Add(Double.Parse(colenSplit[1]));
                    }
                    else if (colenSplit[1].Equals("2")) // Super effective
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[0].Add(entry.Value);
                                break;
                            }
                        }
                        Value[0].Add(Double.Parse(colenSplit[1]));
                    }
                } // End of CommaSplit For Loop
                commaSplit = attackDefense[1].Split(','); // Fire:.5 >,< Grass:2 // Defense
                for (int j = 0; j < commaSplit.Length; j++)
                {
                    colenSplit = commaSplit[j].Split(':'); // Fire >:< .5
                    if (colenSplit[1].Equals("0")) // Does no effect // Resistant to
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[3].Add(entry.Value);
                                break;
                            }
                        }
                        Value[3].Add(Double.Parse(colenSplit[1]));
                    }
                    else if (colenSplit[1].Equals(".5")) // Not effective // Resistant to
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[3].Add(entry.Value);
                                break;
                            }
                        }
                        Value[3].Add(Double.Parse(colenSplit[1]));
                    }
                    else if (colenSplit[1].Equals("2")) // Super effective // Weak to
                    {
                        foreach (KeyValuePair<string, Image> entry in imageDict)
                        {
                            if (entry.Key.Equals(colenSplit[0]))
                            {
                                Image[2].Add(entry.Value);
                                break;
                            }
                        }
                        Value[2].Add(Double.Parse(colenSplit[1]));
                    }
                } // End of CommaSplit For Loop

                listOfTypes[i] = new Types();
                listOfTypes[i].setName(type);
                listOfTypes[i].setImage(Image);
                listOfTypes[i].setValue(Value);

            } // End of Lines For Loop

            file.Close();
            Globals.setList(listOfTypes);
        }

        private void changeImageBox(Image img, string typeName)
        {
            if (AreEqual(img, pb1.Image)) // Remove
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.poke_beep);
                audio.Play();
                pb1.Image = null;
                Globals.setT1(null);
                Globals.setp1(false);
                removeDataFromTables();

            }
            else if (AreEqual(img, pb2.Image)) // Remove
            {
                SoundPlayer audio = new SoundPlayer(Properties.Resources.poke_beep);
                audio.Play();
                pb2.Image = null;
                Globals.setT2(null);
                Globals.setp2(false);
                removeDataFromTables();
            }
            else if (Globals.getp1() == false) // Add
            {
                pb1.Image = img;
                pb1.Refresh();
                Globals.setp1(true);
                addDataToTables(typeName);
            }
            else if (Globals.getp2() == false) // Add
            {
                pb2.Image = img;
                pb2.Refresh();
                Globals.setp2(true);
                addDataToTables(typeName);
            }

        }

        private void addDataToTables(string typeName)
        {

            if (Globals.getT1() != null && Globals.getT2() != null) return;
            SoundPlayer audio = new SoundPlayer(Properties.Resources.poke_beep);
            audio.Play();
            List<Slot>[] tableData = new List<Slot>[4];
            tableData[0] = Globals.getEA();
            tableData[1] = Globals.getNEA();
            tableData[2] = Globals.getWT();
            tableData[3] = Globals.getRT();
            Dictionary<string, Image> imageDict = Globals.getImageDict();
            int typeNumber = 0;
            var assembly = Assembly.GetExecutingAssembly();
            foreach (KeyValuePair<string, Image> entry in imageDict)
            {
                if (entry.Key.Equals(typeName))
                {
                    break;
                }
                typeNumber++;
            }

            Types typeObj = Globals.getList()[typeNumber];

            if (Globals.getT1() == null)
            {


                for (int j = 0; j < tableData.Length; j++)
                {
                    for (int i = 0; i < typeObj.Image[j].Count; i++)
                    {
                        tableData[j].Add(new Slot("L", ResizeImage(typeObj.Image[j].ElementAt(i), 50, 20), typeObj.Value[j].ElementAt(i))); // no 1 or 2 num, image, double value, no text value
                    }
                }
                Globals.setT1(typeObj);
            }
            else if (Globals.getT2() == null)
            {
                for (int j = 0; j < tableData.Length; j++)
                {
                    for (int i = 0; i < typeObj.Image[j].Count; i++)
                    {
                        tableData[j].Add(new Slot("R", ResizeImage(typeObj.Image[j].ElementAt(i), 50, 20), typeObj.Value[j].ElementAt(i))); // no 1 or 2 num, image, double value, no text value
                    }
                }
                Globals.setT2(typeObj);
            }
            Globals.setEA(tableData[0]);
            Globals.setNEA(tableData[1]);
            Globals.setWT(tableData[2]);
            Globals.setRT(tableData[3]);
            updateTablesWithData();
        }

        private void removeDataFromTables()
        {
            List<Slot>[] tableData = new List<Slot>[4];
            tableData[0] = new List<Slot>();
            tableData[1] = new List<Slot>();
            tableData[2] = new List<Slot>();
            tableData[3] = new List<Slot>();
            if (Globals.getT1() != null || Globals.getT2() != null)
            {
                Dictionary<string, Image> imageDict = Globals.getImageDict();
                int typeNumber = 0;
                var assembly = Assembly.GetExecutingAssembly();
                foreach (KeyValuePair<string, Image> entry in imageDict)
                {
                    if (Globals.getT1() != null)
                    {
                        if (entry.Key.Equals(Globals.getT1().getName()))
                        {
                            break;
                        }
                    }
                    else if (Globals.getT2() != null)
                    {
                        if (entry.Key.Equals(Globals.getT2().getName()))
                        {
                            break;
                        }
                    }

                    typeNumber++;
                }

                Types typeObj = Globals.getList()[typeNumber];
                if (Globals.getT1() != null)
                {
                        for (int j = 0; j < tableData.Length; j++)
                        {
                            for (int i = 0; i < typeObj.Image[j].Count; i++)
                            {
                                tableData[j].Add(new Slot("L", ResizeImage(typeObj.Image[j].ElementAt(i), 50, 20), typeObj.Value[j].ElementAt(i))); // no 1 or 2 num, image, double value, no text value
                            }
                        }
                }
                else if (Globals.getT2() != null)
                {
                    for (int j = 0; j < tableData.Length; j++)
                    {
                        for (int i = 0; i < typeObj.Image[j].Count; i++)
                        {
                            tableData[j].Add(new Slot("R", ResizeImage(typeObj.Image[j].ElementAt(i), 50, 20), typeObj.Value[j].ElementAt(i))); // no 1 or 2 num, image, double value, no text value
                        }
                    }
                }
                Globals.setEA(tableData[0]);
                Globals.setNEA(tableData[1]);
                Globals.setWT(tableData[2]);
                Globals.setRT(tableData[3]);
                updateTablesWithData();
            }
            else if (Globals.getT1() == null && Globals.getT2() == null) {
                DataGridView[] tableList = new DataGridView[4];
                tableList[0] = dgEA;
                tableList[1] = dgNEA;
                tableList[2] = dgWT;
                tableList[3] = dgRT;
                foreach (DataGridView dgv in tableList) dgv.Rows.Clear();
                Globals.setEA(tableData[0]);
                Globals.setNEA(tableData[1]);
                Globals.setWT(tableData[2]);
                Globals.setRT(tableData[3]);
                updateTablesWithData();
            }
        }

        private void updateTablesWithData()
        {
            DataGridView[] tableList = new DataGridView[4];
            tableList[0] = dgEA;
            tableList[1] = dgNEA;
            tableList[2] = dgWT;
            tableList[3] = dgRT;

            List<Slot>[] tableData = new List<Slot>[4];
            tableData[0] = Globals.getEA();
            tableData[1] = Globals.getNEA();
            tableData[2] = Globals.getWT();
            tableData[3] = Globals.getRT();

            if (Globals.getT1() == null && Globals.getT2() == null)
            {
                foreach (DataGridView dgv in tableList) dgv.Rows.Clear();
                foreach (List<Slot> list in tableData) list.Clear();
                return;
            }
            Dictionary<double, string> multiplierDict = Globals.getMultiplierDict();

            for (int j = 0; j < tableData.Length; j++) // For every table
            {
                for (int i = 0; i < tableData[j].Count; i++) // For every row
                {
                    for (int k = 0; k < tableData[j].Count; k++) // For every other row
                    {
                        if (AreEqual((Image)tableData[j].ElementAt(i).getImage(), (Image)tableData[j].ElementAt(k).getImage()) && k != i) // If images are the same and it is not the same row
                        {
                            double num = Convert.ToDouble(tableData[j].ElementAt(i).getValue()) * Convert.ToDouble(tableData[j].ElementAt(k).getValue());
                            if(j > 1) tableData[j].ElementAt(i).setValue(num);
                            tableData[j].ElementAt(i).setOwner("L & R");
                            tableData[j].RemoveAt(k);
                        }
                    }

                    if (j == 3) // Removes when this type is resistant to and weak to a specific type
                    {
                        for (int k = 0; k < tableData[j - 1].Count; k++)
                        {
                            if (i < 0)
                            {
                                i = 0;
                            }
                            if (k < 0)
                            {
                                k = 0;
                            }
                            if (AreEqual((Image)tableData[j].ElementAt(i).getImage(), (Image)tableData[j - 1].ElementAt(k).getImage())) // If images are the same
                            {
                                double num = Convert.ToDouble(tableData[j].ElementAt(i).getValue()) * Convert.ToDouble(tableData[j - 1].ElementAt(k).getValue());
                                if (num == 1)
                                {
                                    tableData[j].RemoveAt(i);
                                    tableData[j - 1].RemoveAt(k);
                                    i--;
                                    k--;
                                }
                                else if (num < 1) // Stays in resistant to or not effective table
                                {
                                    tableData[j - 1].RemoveAt(k);
                                    k--;
                                    tableData[j].ElementAt(i).setValue(num);
                                }
                                else if (num > 1) // Stays in super effective or weak to table
                                {
                                    tableData[j].RemoveAt(i);
                                    i--;
                                    tableData[j - 1].ElementAt(k).setValue(num);
                                }

                            }

                        } // End of for loop

                    } // End of j == 3
                } // End of for every row loop
            } // End of for every table loop
            

            // Sorts the right tables in ascending order, and the left tables in descending order
            for (int a = 0; a < tableData.Length; a++)
            {
                // Order top tables by L > L & R > R then sorted by numeric values
                if(a < 2) tableData[a].Sort((s1, s2) => s1.getOwner().CompareTo(s2.getOwner()));

                if (a == 1 || a == 3)
                {
                    tableData[a].Sort((s1, s2) => s1.getValue().CompareTo(s2.getValue()));
                }
                else
                {
                    tableData[a].Sort((s1, s2) => s2.getValue().CompareTo(s1.getValue()));
                }

            }


            // Input the data into the tables
            for (int j = 0; j < 4; j++) // For every table
            {
                tableList[j].Rows.Clear();
                for (int i = 0; i < tableData[j].Count; i++) // For every row
                {
                    tableList[j].Rows.Add();
                    foreach (KeyValuePair<double, string> entry in multiplierDict)
                    {
                        double n1 = tableData[j].ElementAt(i).getValue();
                        double n2 = entry.Key;
                        if (n1.Equals(n2)) { tableList[j].Rows[i].Cells[1].Value = entry.Value; break; }
                    }
                    //tableList[j].Rows[i].Cells[1].Value = tableData[j].ElementAt(i).getValue(); // dont need this line
                    tableList[j].Rows[i].Cells[0].Value = tableData[j].ElementAt(i).getImage();
                    if(j < 2) tableList[j].Rows[i].Cells[2].Value = tableData[j].ElementAt(i).getOwner();
                }

             }
            autoResizeTables();
        }

        private void autoResizeTables()
        {
            DataGridView[] dgvList = { dgEA, dgNEA, dgWT, dgRT };

            foreach (DataGridView dgv in dgvList)
            {
                for (int i = 0; i < dgv.Columns.Count - 1; i++)
                {
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgv.Columns[dgv.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    int colw = dgv.Columns[i].Width;
                    dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgv.Columns[i].Width = colw;
                }
            }

        }


        private void btnBug_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Bug, "Bug");
        }

        private void btnDark_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Dark, "Dark");
        }

        private void btnDragon_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Dragon, "Dragon");
        }

        private void btnElectric_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Electric, "Electric");
        }

        private void btnFairy_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Fairy, "Fairy");
        }

        private void btnFighting_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Fighting, "Fighting");
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Fire, "Fire");
        }

        private void btnFlying_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Flying, "Flying");
        }

        private void btnGhost_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Ghost, "Ghost");
        }

        private void btnGrass_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Grass, "Grass");
        }

        private void btnGround_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Ground, "Ground");
        }

        private void btnIce_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Ice, "Ice");
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Normal, "Normal");
        }

        private void btnPoison_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Poison, "Poison");
        }

        private void btnPsychic_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Psychic, "Psychic");
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Rock, "Rock");
        }

        private void btnSteel_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Steel, "Steel");
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            changeImageBox(Properties.Resources.Water, "Water");
        }


        private void txtBody_TextChanged(TextBox txtBody)
        {
            // amount of padding to add
            const int padding = 3;
            // get number of lines (first line is 0, so add 1)
            int numLines = txtBody.GetLineFromCharIndex(txtBody.TextLength) + 1;
            // get border thickness
            int border = txtBody.Height - txtBody.ClientSize.Height;
            // set height (height of one line * number of lines + spacing)
            if (txtBody.Font.Height * numLines + padding + border > 180) txtBody.Height = 170;
            else txtBody.Height = txtBody.Font.Height * numLines + padding + border;

        }


        private void buttonFont_Click(object sender, EventArgs e)
        {
            prompt = new Form();
            prompt.MaximizeBox = false;
            prompt.MinimizeBox = false;
            prompt.ShowIcon = false;
            prompt.AutoSize = true;
            prompt.Text = "Font";
            prompt.FormBorderStyle = FormBorderStyle.FixedSingle;
            comboBox = new ComboBox()
            {
                Left = 50,
                Top = 10,
                Width = 170
            };
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            fontNames = FontFamily.Families.Select(f => f.Name).ToList();
            comboBox.DataSource = fontNames;
            comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            textBox = new TextBox() { Left = 50, Top = 50, Width = 200};
            textBox.Cursor = Cursors.Default;
            textBox.Multiline = true;
            textBox.AutoSize = false;
            textBox.BorderStyle = BorderStyle.None;
            textBox.Text = "Pick One Or Two Types\r\nLeft (L) Right (R)\r\nEffective Against\r\nNot Effective Against\r\nWeak To\r\nResistant To";
            textBox.Font = new Font(fontNames.ElementAt(0), 10);
            textBox.ReadOnly = true;
            txtBody_TextChanged(textBox);
            Button cancel = new Button() { Text = "Cancel", Left = 50, Top = 230 };
            Button reset = new Button() { Text = "Default", Left = 110, Top = 230 };
            Button save = new Button() { Text = "Save", Left = 170, Top = 230};
            cancel.Click += new EventHandler(cancel_Click);
            reset.Click += new EventHandler(default_Click);
            save.Click += new EventHandler(save_Click);
            cancel.AutoSize = true;
            cancel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancel.AutoEllipsis = false;
            save.AutoSize = true;
            save.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            save.AutoEllipsis = false;
            reset.AutoSize = true;
            reset.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            reset.AutoEllipsis = false;
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(reset);
            prompt.Controls.Add(save);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(comboBox);
            prompt.ShowDialog();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            prompt.Close();
        }

        private void default_Click(object sender, EventArgs e)
        {
            updateFonts("Adobe Gothic Std B");
            string path = Directory.GetCurrentDirectory() + @"\Font.bin";
            SerializeObject("Adobe Gothic Std B", path);
            prompt.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            // Retrieve the selected font family
            string selectedValue = (string) comboBox.SelectedItem;

            // Write the font to a binary file
            string path = Directory.GetCurrentDirectory() + @"\Font.bin";
            SerializeObject<string>(selectedValue, path);

            // Change the all font familys to match the selected font family
            updateFonts(selectedValue);
            prompt.Close();
        }

        private void updateFonts(String newFont)
        {
            label1.Font = new Font(newFont, label1.Font.Size);
            label6.Font = new Font(newFont, label6.Font.Size);
            label7.Font = new Font(newFont, label7.Font.Size);
            label2.Font = new Font(newFont, label2.Font.Size);
            label3.Font = new Font(newFont, label3.Font.Size);
            label4.Font = new Font(newFont, label4.Font.Size);
            label5.Font = new Font(newFont, label5.Font.Size);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox = (ComboBox) sender;
            string selectedValue = (string)comboBox.SelectedItem;
            int resultIndex = -1;
            resultIndex = comboBox.FindStringExact(selectedValue);
            textBox.Font = new Font(fontNames.ElementAt(resultIndex), 8);
            txtBody_TextChanged(textBox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

public static class Globals
{
    private static Types t1 = null, t2 = null;
    private static Types[] list = new Types[18];
    private static List<Slot> listEA, listNEA, listWT, listRT;
    private static Dictionary<string, Image> imageDict = new Dictionary<string, Image>()
    {
    {"Bug", PokemonTypeAnalyzer.Properties.Resources.Bug}, {"Dark", PokemonTypeAnalyzer.Properties.Resources.Dark},
    {"Dragon", PokemonTypeAnalyzer.Properties.Resources.Dragon}, {"Electric", PokemonTypeAnalyzer.Properties.Resources.Electric},
    {"Fairy", PokemonTypeAnalyzer.Properties.Resources.Fairy},  {"Fighting", PokemonTypeAnalyzer.Properties.Resources.Fighting},
    {"Fire", PokemonTypeAnalyzer.Properties.Resources.Fire}, {"Flying", PokemonTypeAnalyzer.Properties.Resources.Flying},
    {"Ghost", PokemonTypeAnalyzer.Properties.Resources.Ghost}, {"Grass", PokemonTypeAnalyzer.Properties.Resources.Grass},
    {"Ground", PokemonTypeAnalyzer.Properties.Resources.Ground}, {"Ice", PokemonTypeAnalyzer.Properties.Resources.Ice},
    {"Normal", PokemonTypeAnalyzer.Properties.Resources.Normal},  {"Poison", PokemonTypeAnalyzer.Properties.Resources.Poison},
    {"Psychic", PokemonTypeAnalyzer.Properties.Resources.Psychic},  {"Rock", PokemonTypeAnalyzer.Properties.Resources.Rock},
    {"Steel", PokemonTypeAnalyzer.Properties.Resources.Steel},  {"Water", PokemonTypeAnalyzer.Properties.Resources.Water},
    };

    private static Dictionary<double, string> multiplierDict = new Dictionary<double, string>()
    {
    {0, "  0 "}, // Immune
    {.25, "  \u00BC "}, // lol weak
    {.5, "  \u00BD "}, // Not Effective
    {2, "  2 "}, // Super Effective
    {4, "  4 "}, // 2X Super Effective

    };
    private static Boolean p1, p2;

    public static Boolean getp1()
    {
        return p1;
    }
    public static void setp1(Boolean value)
    {
        p1 = value;
    }

    public static Boolean getp2()
    {
        return p2;
    }
    public static void setp2(Boolean value)
    {
        p2 = value;
    }

    public static Dictionary<string, Image> getImageDict()
    {
        return imageDict;
    }

    public static Dictionary<double, string> getMultiplierDict()
    {
        return multiplierDict;
    }
    public static Types[] getList()
    {
        return list;
    }

    public static void setList(Types[] value)
    {
        list = value;
    }

    public static Types getT1()
    {
        return t1;
    }

    public static void setT1(Types value)
    {
        t1 = value;
    }

    public static Types getT2()
    {
        return t2;
    }

    public static void setT2(Types value)
    {
        t2 = value;
    }

    public static void setEA(List<Slot> value)
    {
        listEA = new List<Slot>();
        listEA.AddRange(value);
    }

    public static void setNEA(List<Slot> value)
    {
        listNEA = new List<Slot>();
        listNEA.AddRange(value);
    }

    public static void setWT(List<Slot> value)
    {
        listWT = new List<Slot>();
        listWT.AddRange(value);
    }

    public static void setRT(List<Slot> value)
    {
        listRT = new List<Slot>();
        listRT.AddRange(value);
    }

    public static List<Slot> getEA()
    {
        if (listEA == null) listEA = new List<Slot>();
        return listEA;
    }

    public static List<Slot> getNEA()
    {
        if (listNEA == null) listNEA = new List<Slot>();
        return listNEA;
    }

    public static List<Slot> getWT()
    {
        if (listWT == null) listWT = new List<Slot>();
        return listWT;
    }

    public static List<Slot> getRT()
    {
        if (listRT == null) listRT = new List<Slot>();
        return listRT;
    }


}

public class Types
{
    public string name;
    public List<Image>[] Image;
    public List<double>[] Value;

    public Types()
    {
        name = "";
        Image = new List<Image>[4];
        Image[0] = new List<Image>();
        Image[1] = new List<Image>();
        Image[2] = new List<Image>();
        Image[3] = new List<Image>();
        Value = new List<double>[4];
        Value[0] = new List<double>();
        Value[1] = new List<double>();
        Value[2] = new List<double>();
        Value[3] = new List<double>();
    }

    public Types(string n, List<Image>[] img, List<double>[] val)
    {
        name = n;
        Image = img;
        Value = val;
    }

    public string getName()
    {
        return name;
    }

    public void setName(string value)
    {
        name = value;
    }
    public void setImage(List<Image>[] value)
    {
        value.CopyTo(Image, 0);
    }
    public void setValue(List<double>[] value)
    {
        value.CopyTo(Value, 0);
    }

    public void ToString()
    {
        Debug.WriteLine("\n" + getName() + " is effective against:");
        for (int j = 0; j < Image[0].Count; j++)
        {
            foreach (KeyValuePair<string, Image> entry in Globals.getImageDict())
            {
                if (MainFrame.AreEqual(entry.Value, Image[0].ElementAt(j)))
                {
                    Debug.WriteLine("\t" + entry.Key + " " + Value[0].ElementAt(j));
                    break;
                }
            }
        }
        Debug.WriteLine("\n" + getName() + " is not effective against:");
        for (int j = 0; j < Image[1].Count; j++)
        {
            foreach (KeyValuePair<string, Image> entry in Globals.getImageDict())
            {
                if (MainFrame.AreEqual(entry.Value, Image[1].ElementAt(j)))
                {
                    Debug.WriteLine("\t" + entry.Key + " " + Value[1].ElementAt(j));
                    break;
                }
            }
        }
        Debug.WriteLine("\n" + getName() + " is resistant to:");
        for (int j = 0; j < Image[3].Count; j++)
        {
            foreach (KeyValuePair<string, Image> entry in Globals.getImageDict())
            {
                if (MainFrame.AreEqual(entry.Value, Image[3].ElementAt(j)))
                {
                    Debug.WriteLine("\t" + entry.Key + " " + Value[3].ElementAt(j));
                    break;
                }
            }
        }
        Debug.WriteLine("\n" + getName() + " is weak to:");
        for (int j = 0; j < Image[2].Count; j++)
        {
            foreach (KeyValuePair<string, Image> entry in Globals.getImageDict())
            {
                if (MainFrame.AreEqual(entry.Value, Image[2].ElementAt(j)))
                {
                    Debug.WriteLine("\t" + entry.Key + " " + Value[2].ElementAt(j));
                    break;
                }
            }
        }
    }

}


public class Slot
{
    private string owner, text;
    private double value;
    private Image image;
    private static Dictionary<double, string> multiplierDict = Globals.getMultiplierDict();

    public Slot(string o, Image img, double v)
    {
        owner = o;
        image = img;
        value = v;

        foreach (KeyValuePair<double, string> entry in multiplierDict)
        {
            double n1 = v;
            double n2 = entry.Key;
            if (n1.Equals(n2)) { text = entry.Value; break; }
        }
    }

    public string getOwner()
    {
        return owner;
    }

    public Image getImage()
    {
        return image;
    }

    public double getValue()
    {
        return value;
    }

    public string getText()
    {
        return text;
    }

    public void setOwner(string n)
    {
        owner = n;
    }

    public void setValue(double d)
    {
        value = d;
    }

    public void setText(string t)
    {
        text = t;
    }

}