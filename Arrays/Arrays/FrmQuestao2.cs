namespace Arrays
{
    public partial class FrmQuestao2 : Form
    {
        string Input;
        public FrmQuestao2()
        {
            InitializeComponent();
        }

        private void txbInput_Leave(object sender, EventArgs e)
        {
            if (txbInput.Text == "")
            {
                txbInput.Text = @"1,2,3,4...
10,24,5...";
                txbInput.ForeColor = Color.Silver;

            }
        }

        private void txbInput_Click(object sender, EventArgs e)
        {
            txbInput.Text = "";
        }

        private void txbInput_TextChanged(object sender, EventArgs e)
        {
            txbInput.ForeColor = Color.Black;
        }

        private void FrmQuestao2_Load(object sender, EventArgs e)
        {
            btnRanquear.Focus();
        }

        private void btnRanquear_Click(object sender, EventArgs e)
        {
            txbOutput.Text = "";
            Input = txbInput.Text;
            bool testResult = ValidationString(Input);
            if (!testResult)
            {
                txbOutput.ForeColor = Color.Red;
                txbOutput.Text = "Formato inválido";
                return;
            }
            txbOutput.ForeColor = Color.Black;
            txbOutput.Text = Ranking(Input);
        }

        private bool ValidationString(string txt)
        {
            string[] texto = txt.Split('\n');
            if (texto.Length == 1)
            {
                foreach (var caractere in texto[0])
                {
                    if (caractere != ',' & !int.TryParse(caractere.ToString(), out _) & caractere != '\r')
                    {
                        return false;
                    }
                }
                return true;
            }

            foreach (var linha in texto)
            {
                foreach (var caractere in linha)
                {
                    if (caractere != ',' & !int.TryParse(caractere.ToString(), out _) & caractere != '\r')
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < texto.Length - 1; i++)
            {
                int QntVirgulasAtual = texto[i].Split(',').Length;
                int QntVirgulasProx = texto[i + 1].Split(',').Length;
                if (QntVirgulasAtual != QntVirgulasProx)
                {
                    return false;
                }
            }

            return true;
        }
        private string Ranking(string txt)
        {
            string Result = "";
            string[] texto = txt.Split('\n');
            if (texto.Length == 1)
            {
                int[] ArrayInteiros = new int[texto[0].Split(',').Length];
                int i = 0;
                foreach (var caractere in texto[0])
                {
                    if (int.TryParse(caractere.ToString(), out int numb))
                    {
                        ArrayInteiros[i] = numb;
                        i++;
                    }
                }
                int[] IntRanked = RankingAlgorithmArray(ArrayInteiros);
                string LineResult = "";
                for (int j = 0; j < IntRanked.Length; j++)
                {
                    LineResult += IntRanked[j].ToString();
                    if (j + 1 != IntRanked.Length)
                    {
                        LineResult += ',';
                    }
                }
                Result += @$"{LineResult}
";
            }

            else {
                int NumLines = texto.Length;
                int NumColumn = texto[0].Split(',').Length;
                int[] ArrayInt = new int[NumColumn * NumLines];
                int i = 0;

                foreach (var linhas in texto) {
                    foreach (var caractere in linhas) {
                        if (int.TryParse(caractere.ToString(), out int numb)) {
                            ArrayInt[i] = numb;
                            i++;
                        }
                    }
                }
                ArrayInt = RankingAlgorithmArray(ArrayInt);
                i = 0;
                for (int j = 0; j < NumLines; j++) {
                    for (int k = 0; k < NumColumn; k++) {
                        Result += $"{ArrayInt[i]}";
                        i++;
                        if (k != NumColumn - 1) {
                            Result += ",";
                        }
                    }
                        Result += @"
";
                }
            }
            return Result;
        }
        private int[] RankingAlgorithmArray(int[] array)
        {
            Dictionary<int, int> numRanks = array
                .GroupBy(i => i)
                .OrderByDescending(g => g.Key)
                .Select((g, index) => (num: g.Key, rank: index + 1))
                .ToDictionary(x => x.num, x => x.rank);
            int[] result = array.Select(i => numRanks[i]).ToArray();
            return result;
        }
    }
}