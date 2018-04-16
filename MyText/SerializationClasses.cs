[Serializable]
[XmlRoot("FMDescriptor")]
public class FMDescriptor
{
	[XmlElement("FMData")]
	public FMData fmData;
	[XmlArray("Inputs"), XmlArrayItem(typeof(In), ElementName = "In")]
	public List<In> lstInputs;
	[XmlArray("Parameters"), XmlArrayItem(typeof(Parameter), ElementName = "Parameter")]
	public List<Parameter> lstParameters;
	[XmlArray("States"), XmlArrayItem(typeof(State), ElementName = "State")]
	public List<State> lstStates;
	[XmlArray("Outputs"), XmlArrayItem(typeof(Out), ElementName = "Out")]
	public List<Out> lstOutputs;
}
public class FMData
{
	public string FMName;
	public string FMInstanceName;
	public string FMTextDescription;
	public string FMUserTextDescription;
	public string FMVersion;
}
public class Port
{
	public string PortName;
	public string PortDescription;
	public string PortUserDescription;
	public string DataType;
	public string Link;
	public string Objectrequirements;
}
public class In:Port
{
	public bool Activating;
	public bool Rference;
	
}
public class Parameter:Port
{
}
public class State:Port
{
}
public class Out:Port
{
	public bool Connected;
}	
