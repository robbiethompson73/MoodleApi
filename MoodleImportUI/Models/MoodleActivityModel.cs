using Newtonsoft.Json;

namespace MoodleImportUI.Models;

public class MoodleActivityModel
{
	//[JsonProperty("id")]
	public int id { get; set; }

	//[JsonProperty("username")]
	public string username { get; set; }

	//[JsonProperty("logintime")]
	public int logintime { get; set; }


	//[JsonPropertyName("id")]
	//public int MoodleId { get; set; }

	//[JsonPropertyName("username")]
	//public string StudentReferenceNumber { get; set; }

	//[JsonPropertyName("logintime")] 
	//public int DateLastAccessUnix { get; set; }
}


