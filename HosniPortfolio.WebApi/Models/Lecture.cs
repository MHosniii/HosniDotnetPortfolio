using System;

namespace HosniPortfolio.WebApi.Models
{
	public class Lecture
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public Subject Subject { get; set; }
        public string Description { get; set; }
        public string Source { get; set; }
        public DateTime CreationDate { get; set; }
        public int NbLike { get; set; }
		public int NbDislike { get; set; }
	}
}
