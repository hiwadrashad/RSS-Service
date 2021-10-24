using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSS_Service_Library.ModelsTechRepublic
{

		[XmlRoot(ElementName = "image")]
		public class Image
		{

			[XmlElement(ElementName = "url")]
			public string Url { get; set; }

			[XmlElement(ElementName = "link")]
			public string Link { get; set; }

			[XmlElement(ElementName = "title")]
			public string Title { get; set; }

			[XmlElement(ElementName = "width")]
			public int Width { get; set; }

			[XmlElement(ElementName = "height")]
			public int Height { get; set; }
		}

		[XmlRoot(ElementName = "counts")]
		public class Counts
		{

			[XmlElement(ElementName = "start")]
			public int Start { get; set; }

			[XmlElement(ElementName = "return")]
			public int Return { get; set; }

			[XmlElement(ElementName = "found")]
			public int Found { get; set; }
		}

		[XmlRoot(ElementName = "guid")]
		public class Guid
		{

			[XmlAttribute(AttributeName = "isPermaLink")]
			public bool IsPermaLink { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "credit")]
		public class Credit
		{

			[XmlAttribute(AttributeName = "role")]
			public string Role { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

		[XmlRoot(ElementName = "item")]
		public class Item
		{
      		[NotMapped]

		    [XmlElement(ElementName = "guid")]

			public Guid Guid { get; set; }

			[XmlElement(ElementName = "link")]
			public string Link { get; set; }

			[XmlElement(ElementName = "title")]
			public string Title { get; set; }

			[XmlElement(ElementName = "description")]
			public string Description { get; set; }

			[XmlElement(ElementName = "pubDate")]
			public string PubDate { get; set; }

			[XmlElement(ElementName = "credit")]
		[NotMapped]
		public Credit Credit { get; set; }

			[XmlElement(ElementName = "doctype")]
			public string Doctype { get; set; }
		}

		[XmlRoot(ElementName = "channel")]
		public class Channel
		{

			[XmlElement(ElementName = "title")]
			public string Title { get; set; }

			[XmlElement(ElementName = "description")]
			public string Description { get; set; }

			[XmlElement(ElementName = "language")]
			public string Language { get; set; }

			[XmlElement(ElementName = "link")]
			public string Link { get; set; }

			[XmlElement(ElementName = "copyright")]
			public string Copyright { get; set; }

			[XmlElement(ElementName = "pubDate")]
			public DateTime PubDate { get; set; }

			[XmlElement(ElementName = "lastBuildDate")]
			public DateTime LastBuildDate { get; set; }

			[XmlElement(ElementName = "generator")]
			public string Generator { get; set; }

			[XmlElement(ElementName = "docs")]
			public string Docs { get; set; }

			[XmlElement(ElementName = "ttl")]
			public int Ttl { get; set; }

			[XmlElement(ElementName = "image")]
		[NotMapped]
		public Image Image { get; set; }

			[XmlElement(ElementName = "category")]
			public string Category { get; set; }

			[XmlElement(ElementName = "counts")]
		[NotMapped]
		public Counts Counts { get; set; }
		[NotMapped]

		[XmlElement(ElementName = "item")]

			public List<Item> Item { get; set; }
		}

		[XmlRoot(ElementName = "rss")]
		public class TechRepublicRss
		{

		[Key]
		public int Id { get; set; }
		[NotMapped]

		[XmlElement(ElementName = "channel")]
			public Channel Channel { get; set; }

			[XmlAttribute(AttributeName = "media")]
			public string Media { get; set; }

			[XmlAttribute(AttributeName = "atom")]
			public string Atom { get; set; }

			[XmlAttribute(AttributeName = "s")]
			public string S { get; set; }

			[XmlAttribute(AttributeName = "itunes")]
			public string Itunes { get; set; }

			[XmlAttribute(AttributeName = "version")]
			public double Version { get; set; }

			[XmlText]
			public string Text { get; set; }
		}

	
}
