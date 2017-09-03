using System.Collections.Generic;

class ResultService {
	struct PostResult: HTTPRequest {
		int stageId;

		public PostResult(int _stageId) {
			stageId = _stageId;
		}

		public string RelativeUrl {
			get { return "/results/";}
		}
		public Dictionary<string, object> Parameters {
			get {
				return new Dictionary<string, object>() {
					{ "stage_id", stageId }
				};
			}
		}
	}

	struct UpdateResult: HTTPRequest {
		int id;

		public UpdateResult(int _id) {
			id = _id;
		}
		public string RelativeUrl {
			get { return "/results/" + id;}
		}
		public Dictionary<string, object> Parameters {
			get {
				return new Dictionary<string, object>();
			}
		}
	}
}
