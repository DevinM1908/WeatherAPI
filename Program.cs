namespace WeatherAPP
{
    using Serilog;
    using Elastic.CommonSchema.Serilog;
    using Elastic.Serilog.Sinks;
    using Elastic.Clients.Elasticsearch;
    using Elastic.Transport;
    using Elastic.Clients.Elasticsearch.MachineLearning;

    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        [STAThread]
        public static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var settings = new ElasticsearchClientSettings(new Uri("https://my-deployment.es.australiaeast.azure.elastic-cloud.com")).Authentication(new ApiKey("dFhKSWI1TUJFc0JxbFk4dDFtMzQ6MDR1bDRjZ29TZTZqMnZQSExtZWpEZw=="));
            var client = new ElasticsearchClient(settings);

            //Configuring Serilog
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.Console().WriteTo.Sink(new ElasticsearchSink(client,"Weather App Telemetry")).CreateLogger();

            //Test Message
            Log.Information("Weather app Initialized");

            Application.Run(new Form1());
        
        }
    }
}