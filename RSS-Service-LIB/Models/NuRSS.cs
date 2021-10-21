using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RSS_Service_LIB.ModelsNu
{
	[XmlRoot(ElementName = "link")]
	public class Link
	{

		[XmlAttribute(AttributeName = "href")]
		public string Href { get; set; }

		[XmlAttribute(AttributeName = "rel")]
		public string Rel { get; set; }

		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }
	}

	[XmlRoot(ElementName = "guid")]
	public class Guid
	{

		[XmlAttribute(AttributeName = "isPermaLink")]
		public bool IsPermaLink { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "enclosure")]
	public class Enclosure
	{

		[XmlAttribute(AttributeName = "length")]
		public int Length { get; set; }

		[XmlAttribute(AttributeName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "url")]
		public string Url { get; set; }
	}

	[XmlRoot(ElementName = "item")]
	public class Item
	{

		[XmlElement(ElementName = "category")]
		public List<string> Category { get; set; }

		[XmlElement(ElementName = "creator")]
		public string Creator { get; set; }

		[XmlElement(ElementName = "rights")]
		public string Rights { get; set; }

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "link")]
		public string Link { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "pubDate")]
		public string PubDate { get; set; }

		[XmlElement(ElementName = "guid")]
		public Guid Guid { get; set; }

		[XmlElement(ElementName = "enclosure")]
		public Enclosure Enclosure { get; set; }
	}

	[XmlRoot(ElementName = "channel")]
	public class Channel
	{

		[XmlElement(ElementName = "title")]
		public string Title { get; set; }

		[XmlElement(ElementName = "link")]
		public List<string> Link { get; set; }

		[XmlElement(ElementName = "description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "language")]
		public string Language { get; set; }

		[XmlElement(ElementName = "copyright")]
		public string Copyright { get; set; }

		[XmlElement(ElementName = "lastBuildDate")]
		public DateTime LastBuildDate { get; set; }

		[XmlElement(ElementName = "ttl")]
		public int Ttl { get; set; }

		[XmlElement(ElementName = "logo")]
		public string Logo { get; set; }

		[XmlElement(ElementName = "item")]
		public List<Item> Item { get; set; }
	}

	[XmlRoot(ElementName = "rss")]
	public class NuRss
	{

		[XmlElement(ElementName = "channel")]
		public Channel Channel { get; set; }

		[XmlAttribute(AttributeName = "version")]
		public double Version { get; set; }

		[XmlAttribute(AttributeName = "atom")]
		public string Atom { get; set; }

		[XmlAttribute(AttributeName = "dc")]
		public string Dc { get; set; }

		[XmlAttribute(AttributeName = "media")]
		public string Media { get; set; }

		[XmlText]
		public string Text { get; set; }
	}

}
