
// Copyright (c) 2015 Roman Kuzmin
// http://www.apache.org/licenses/LICENSE-2.0

using System.Management.Automation;
using System.Xml;

namespace Xmlips.Commands
{
	[Cmdlet(VerbsCommon.Add, "Xml")]
	[OutputType(typeof(XmlElement))]
	public sealed class AddXmlCommand : PSCmdlet
	{
		[Parameter(Position = 0)]
		public string Tag { get; set; }

		[Parameter(Position = 1, ValueFromPipeline = true)]
		public XmlElement[] Xml
		{
			get { return _Xml; }
			set
			{
				_Xml = value;
				_XmlSet = true;
			}
		}
		XmlElement[] _Xml;
		bool _XmlSet;

		protected override void BeginProcessing()
		{
			if (string.IsNullOrEmpty(Tag)) throw new PSArgumentNullException("Tag");
		}

		void ProcessItem(XmlElement xml)
		{
			if (xml == null) throw new PSArgumentNullException("Xml (item)");

			var elem = xml.OwnerDocument.CreateElement(Tag);
			xml.AppendChild(elem);
			WriteObject(elem);
		}

		protected override void ProcessRecord()
		{
			if (!_XmlSet) throw new PSArgumentException("Xml is required.");
			if (Xml == null) return;

			foreach (var item in Xml)
				ProcessItem(item);
		}
	}
}
