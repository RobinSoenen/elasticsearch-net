// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

// Contains internal parameterless constructors used by the deserializer.

#if ELASTICSEARCH_SERVERLESS
namespace Elastic.Clients.Elasticsearch.Serverless
#else
namespace Elastic.Clients.Elasticsearch
#endif
{
	namespace Eql
	{
		public partial class EqlSearchRequest
		{
			internal EqlSearchRequest()
			{ }
		}
	}

	namespace IndexManagement
	{
		public partial class PutMappingRequest
		{
			internal PutMappingRequest()
			{ }
		}
	}

	namespace IndexManagement
	{
		public partial class PutTemplateRequest
		{
			internal PutTemplateRequest()
			{ }
		}
	}

	namespace Inference
	{
		public partial class InferenceRequest
		{
			internal InferenceRequest()
			{ }
		}
	}

	namespace QueryRules
	{
		public partial class PutRuleRequest
		{
			internal PutRuleRequest()
			{ }
		}
	}

	namespace QueryRules
	{
		public partial class PutRulesetRequest
		{
			internal PutRulesetRequest()
			{ }
		}
	}

	public partial class SearchMvtRequest
	{
		internal SearchMvtRequest()
		{ }
	}

	namespace Snapshot
	{
		public partial class CreateSnapshotRequest
		{
			internal CreateSnapshotRequest()
			{ }
		}
	}

	namespace Synonyms
	{
		public partial class PutSynonymRequest
		{
			internal PutSynonymRequest()
			{ }
		}
	}

	public partial class TermVectorsRequest<TDocument>
	{
		internal TermVectorsRequest()
		{ }
	}

	public sealed partial class UpdateRequest<TDocument, TPartialDocument>
	{
		internal UpdateRequest()
		{ }
	}
}
