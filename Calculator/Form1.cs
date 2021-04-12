using System;
using System.Globalization;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        String output, unu, doi = "două";
        int full, part;
        string[] numere = {
            "zero", "unu", "doi", "trei", "patru", "cinci",
            "șase", "șapte", "opt", "nouă"};

        string[] numbers = {
            "zero", "one", "two", "three", "four", "five",
            "six", "seven", "eight", "nine"
        };

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            comboBox_valuta.SelectedItem = 0;
            comboBox_valuta.SelectedIndex = 0;
        }

        private void button_Ro_Click(object sender, EventArgs e)
        {
            createTextRo();
            MessageBox.Show(output, "Răspuns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(output);
            output = "";

        }

        private void button_Eng_Click(object sender, EventArgs e)
        {
            createTextEng();
            MessageBox.Show(output, "Răspuns", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(output);
            output = "";

        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            string s = numericUpDown.Value.ToString("0.00", CultureInfo.InvariantCulture);
            string[] parts = s.Split('.');
            full = int.Parse(parts[0]);
            part = int.Parse(parts[1]);
        }

        private void createTextRo()
        {
            string s = numericUpDown.Value.ToString("0.00", CultureInfo.InvariantCulture);
            string[] parts = s.Split('.');
            full = int.Parse(parts[0]);
            part = int.Parse(parts[1]);

            //MILIARDE
            if (full > 999999999)
            {
                int number = full / 1000000000;
                setOne('b');
                createSute(number);
                output += number switch
                {
                    1 => "miliard",
                    _ => "miliarde",
                };

                full %= 1000000000;
            }


            //MILIOANE
            if (full > 999999)
            {
                int number = full / 1000000;

                setOne('m');
                createSute(number);

                switch (number)
                {
                    case 0:
                        break;
                    case 1:
                        output += "milion";
                        break;
                    case int n when n >= 2 && n <= 19:
                        output += "milioane";
                        break;
                    default:
                        output += "demilioane";
                        break;
                }
                full %= 1000000;
            }

            //MII
            if (full > 999)
            {
                int number = full / 1000;

                setOne('k');
                createSute(number);

                switch (number)
                {
                    case 0:
                        break;
                    case 1:
                        output += "mie";
                        break;
                    case int n when n >= 2 && n <= 19:
                        output += "mii";
                        break;
                    default:
                        output += "demii";
                        break;
                }
                full %= 1000;
            }

            //RESTUL
            setOne('n');
            createSute(full);

            if (full == 1)
            {
                output += comboBox_valuta.SelectedIndex == 0 ? "leu" : "lei";
            }
            else
            {
                output += comboBox_valuta.SelectedItem.ToString().ToLower();
            }


            if (part != 0)
            {
                output += ',';
                setOne('b');
                createSute(part);

                if (comboBox_valuta.SelectedIndex == 0)
                {
                    if (part == 1)
                    {
                        output += "ban";
                    }
                    else
                    {
                        output += "bani";
                    }
                }
                else
                {
                    if (part == 1)
                    {
                        output += "eurocent";
                    }
                    else
                    {
                        output += "eurocenți";
                    }
                }
            }

        }

        private void createTextEng()
        {
            string s = numericUpDown.Value.ToString("0.00", CultureInfo.InvariantCulture);
            string[] parts = s.Split('.');
            full = int.Parse(parts[0]);
            part = int.Parse(parts[1]);

            string fullString = full.ToString();

            while (fullString.Length > 0)
            {
                output += numbers[Int32.Parse(fullString[0].ToString())];
                fullString = fullString.Substring(1, fullString.Length - 1);
            }


            if (full != 0)
            {
                output += comboBox_valuta.SelectedItem.ToString().ToLower();
            }

            if (part != 0)
            {
                output += ',';
                string partString = part.ToString();

                while (partString.Length > 0)
                {
                    output += numbers[Int32.Parse(partString[0].ToString())];
                    partString = partString.Substring(1, partString.Length - 1);
                }

                if (part == 1)
                {
                    output += "eurocent";
                }
                else
                {
                    output += "eurocents";
                }
            }
        }

        private void createSute(int number)
        {
            Boolean ok = true;
            Boolean before = false;
            if (number >= 100 && number <= 999)
            {
                output += (number / 100) switch
                {
                    0 => "",
                    1 => "osută",
                    2 => "douăsute",
                    _ => $"{numere[number / 100]}sute",
                };
                before = true;
                number %= 100;
            }


            if (number >= 10 && number <= 19)
            {
                output += number switch
                {
                    10 => "zece",
                    _ => $"{numere[number % 10]}sprezece",
                };
                number %= 10;
                before = true;
                ok = false;
            }

            if (number >= 20 && number <= 99)
            {
                output += (number / 10) switch
                {
                    2 => "douăzeci",
                    6 => "șaizeci",
                    _ => $"{numere[number / 10]}zeci",
                };
                before = true;
                number %= 10;
            }

            if ((number >= 1 && number <= 9) && ok)
                if (before)
                {
                    output += $"și{numere[number]}";
                }
                else
                {
                    if (number == 1)
                    {
                        output += unu;
                    }
                    else if (number == 2)
                    {
                        output += doi;
                    }
                    else
                    {
                        output += $"{numere[number]}";
                    }
                }
        }

        private void setOne(char item)
        {
            if (item == 'b')
            {
                unu = "un";
                doi = "două";
            }
            else if (item == 'm')
            {
                unu = "un";
                doi = "două";
            }
            else if (item == 'k')
            {
                unu = "o";
                doi = "două";
            }
            else if (item == 'n')
            {
                unu = "un";
                doi = "doi";
            }

        }

    }
}
