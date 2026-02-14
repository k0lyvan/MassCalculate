namespace MassCalculate
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            DGV1.Rows.Add();
            DGV2.Rows.Add();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Add();
        }

        private void btnAddColm_Click(object sender, EventArgs e)
        {
            DGV1.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            DGV1.Rows.Clear();
            DGV1.Columns.Clear();
            DGV1.Columns.Add(new DataGridViewTextBoxColumn());
            DGV1.Rows.Add();
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            int rowsCount = DGV1.RowCount;
            DGV1.Rows.Clear();
            DGV1.Rows.Add(rowsCount);
        }

        private void btnDel2_Click(object sender, EventArgs e)
        {
            DGV2.Rows.Clear();
            DGV2.Columns.Clear();
            DGV2.Columns.Add(new DataGridViewTextBoxColumn());
            DGV2.Rows.Add();
        }

        private void btnAddRow2_Click(object sender, EventArgs e)
        {
            DGV2.Rows.Add();
        }

        private void btnAddColm2_Click(object sender, EventArgs e)
        {
            DGV2.Columns.Add(new DataGridViewTextBoxColumn());
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            int rowsCount = DGV2.RowCount;
            DGV2.Rows.Clear();
            DGV2.Rows.Add(rowsCount);
        }
    }
}
