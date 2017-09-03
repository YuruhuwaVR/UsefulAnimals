using System.Collections.Generic;

interface HTTPRequest {
	string RelativeUrl { get; }
	Dictionary<string, object> Parameters { get; }
}
