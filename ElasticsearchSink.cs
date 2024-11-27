using Elastic.Clients.Elasticsearch;
using Serilog.Core;
using Serilog.Events;

namespace WeatherAPP
{
    public class ElasticsearchSink : ILogEventSink
    {
        private readonly ElasticsearchClient _elasticsearchClient;
        private readonly string _indexName;

        public ElasticsearchSink(ElasticsearchClient client, String IndexName)
        {
            _elasticsearchClient = client;
            _indexName = IndexName;
        }

        public void Emit(LogEvent logEvent)
        {
            var logDocument = new
            {
                Timestamp = logEvent.Timestamp,
                Level = logEvent.Level.ToString(),
                Message = logEvent.RenderMessage(),
                Exception = logEvent.Exception?.ToString(),
                Properties = logEvent.Properties
            };

            _elasticsearchClient.Index(logDocument, i => i.Index(_indexName));

        }
    }
}
