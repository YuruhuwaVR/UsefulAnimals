using System.Collections.Generic;

class StageService {
	struct GetStages: HTTPRequest {
		int level;
		int page;
		int userId;

		public GetStages(int _level, int _page, int _userId) {
			level  =  _level;
			page   =   _page;
			userId = _userId;
		}

		public string RelativeUrl {
			get { return "/stages/";}
		}
		public Dictionary<string, object> Parameters {
			get {
				return new Dictionary<string, object>() {
					{ "level"  , level  },
					{ "page"   , page   },
					{ "user_id", userId }
				};
			}
		}
	}

	struct GetStageCSV: HTTPRequest {
		int stageId;
		public GetStageCSV(int _stageId) {
			stageId = _stageId;
		}

		public string RelativeUrl {
			get { return "/stages/" + stageId;}
		}
		public Dictionary<string, object> Parameters {
			get {
				return new Dictionary<string, object>();
			}
		}
	}

	struct PostStage: HTTPRequest {
		string name;
		// hoge csv;

		public PostStage(string _name) {
			name = _name;
			// csv = _csv;
		}

		public string RelativeUrl {
			get { return "/stages/";}
		}
		public Dictionary<string, object> Parameters {
			get {
				return new Dictionary<string, object>() {
					{ "name", name }
					// { "csv", csv }
				};
			}
		}
	}
}
