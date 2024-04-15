using System;
using System.ComponentModel.DataAnnotations;

namespace Animal_Assignment3.Models
{
	public class AnimalList
	{
		//create variable for each item
		public int Id { get; set; }
		[Required]
		public string ?Name { get; set; }
        public string? Image { get; set; }
        public string ?Species { get; set; }
        public string? Population { get; set; }


    }
	}