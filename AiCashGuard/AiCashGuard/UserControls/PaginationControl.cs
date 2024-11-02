using System;
using System.Windows.Forms;

namespace AiCashGuard.UserControls
{
	public partial class PaginationControl : UserControl
	{
		
		private void PaginationControl_Load(object sender, EventArgs e)
		{

		}
		public int TotalPages { get; set; }
		public int CurrentPage { get; private set; }
		public int ItemsPerPage { get; set; } = 10;

		// Event to notify when page changes
		public event EventHandler PageChanged;

		public PaginationControl()
		{
			InitializeComponent();
			CurrentPage = 1;
			UpdatePaginationControls();
		}

		// Method to trigger the PageChanged event
		private void OnPageChanged()
		{
			PageChanged?.Invoke(this, EventArgs.Empty);
		}

		private void UpdatePaginationControls()
		{
			lblPageNumber.Text = $"Page {CurrentPage} of {TotalPages}";
			btnPrevious.Enabled = CurrentPage > 1;
			btnNext.Enabled = CurrentPage < TotalPages;
		}

		public void SetTotalPages(int totalItems)
		{
			TotalPages = (int)Math.Ceiling((double)totalItems / ItemsPerPage);
			UpdatePaginationControls();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnNext_Click_1(object sender, EventArgs e)
		{
			if (CurrentPage < TotalPages)
			{
				CurrentPage++;
				UpdatePaginationControls();
				OnPageChanged();
			}
		}

		private void btnPrevious_Click_1(object sender, EventArgs e)
		{
			if (CurrentPage > 1)
			{
				CurrentPage--;
				UpdatePaginationControls();
				OnPageChanged();
			}
		}

		private void lblPageNumber_Click(object sender, EventArgs e)
		{

		}
	}
}
