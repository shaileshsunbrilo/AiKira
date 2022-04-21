using System;
using System.Collections.Generic;
using System.Text;

namespace AikiraPOC_Core.Models.ResponseModel
{
    public class FileInfoBookResponseModel
    {
		public int PsId { get; set; }
		public int FileId { get; set; }
		public string FileName { get; set; }
		public int BookId { get; set; }
		public int FileTypeId { get; set; }
		public int CategoryId { get; set; }
		public int BatchId { get; set; }
		public int SequenceId { get; set; }
		public DateTime CreatedDate { get; set; }
		public string Volume { get; set; }
		public string Issue { get; set; }
		public string IsUnallocated { get; set; }
		public string Language { get; set; }
		public string StartPagePrint { get; set; }
		public string EndPagePrint { get; set; }
		public string MSPages { get; set; }
		public string CastOffPages { get; set; }
		public string PrintPages { get; set; }
		public string Boxes { get; set; }
		public string TotalFigures { get; set; }
		public string TotalTables { get; set; }
		public string TotalEquations { get; set; }
		public string TotalFootnotes { get; set; }
		public string ArtComplexity { get; set; }
		public string CEComplexity { get; set; }
		public string TSComplexity { get; set; }
		public string FileComplexity { get; set; }
		public string FormatSize { get; set; }
		public string FileTitle { get; set; }
	}
}
