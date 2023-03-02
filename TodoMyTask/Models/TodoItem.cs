using System;
namespace TodoMyTask.Models
{
	public class TodoItem
	{
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public string Text { get; set; }
		public bool Done { get; set; } = false;
	}
}

