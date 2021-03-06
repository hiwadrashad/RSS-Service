using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSS_Service_Library.ModelsTechVisor
{

	[XmlRoot(ElementName = "image")]
	public class Image
	{

		[XmlElement(ElementName = "url")]
		public string Url { get; set; }

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "link")]
		public object Link { get; set; }
	}

	[XmlRoot(ElementName = "link")]
	public class Link
	{

		[XmlAttribute(AttributeName = "rel")]
		public string Rel { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }

		[XmlAttribute(AttributeName = "href")]
		public string Href { get; set; }
	}

	[XmlRoot(ElementName = "enclosure")]
	public class Enclosure
	{

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "url")]
		public string Url { get; set; }

		[XmlAttribute(AttributeName = "width")]
		public int Width { get; set; }

		[XmlAttribute(AttributeName = "height")]
		public int Height { get; set; }
	}

	[XmlRoot(ElementName = "item")]
	public class Item
	{

		[XmlElement(ElementName = "link")]
		public string Link { get; set; }

		[XmlElement(ElementName = "author")]
		public string Author { get; set; }

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }

		[NotMapped]
		[XmlElement(ElementName = "enclosure")]
		public Enclosure Enclosure { get; set; }
	}

	[XmlRoot(ElementName = "channel")]
	public class Channel
	{

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "copyright")]
		public string Copyright { get; set; }

		[XmlElement(ElementName = "lastBuildDate")]
		public DateTime LastBuildDate { get; set; }

		[XmlElement(ElementName = "generator")]
		public string Generator { get; set; }

		[XmlElement(ElementName = "image")]
		[NotMapped]
		public Image Image { get; set; }

		[XmlElement(ElementName = "id")]
		public string Id { get; set; }

		[XmlElement(ElementName = "link")]
		public string Link { get; set; }

		[XmlElement(ElementName = "item")]
		[NotMapped]

		public List<Item> Item { get; set; }
	}

	[XmlRoot(ElementName = "rss")]
	public class TechVisorRss
	{
		[Key]
		public int Id { get; set; }
		[NotMapped]
		[XmlElement(ElementName = "channel")]
		public Channel Channel { get; set; }

		[XmlAttribute(AttributeName = "a10")]
		public string A10 { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public double Version { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
