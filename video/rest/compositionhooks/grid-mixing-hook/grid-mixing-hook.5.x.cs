// Install the C# / .NET helper library from twilio.com/docs/csharp/install

using System;
using System.Collections.Generic;
using Twilio;
using Twilio.Rest.Video.V1;
using static Twilio.Rest.Video.V1.CompositionHookResource;

class Program
{
    static void Main(string[] args)
    {
        // Find your API Key SID and Secret at twilio.com/console
        const string apiKeySid = "SKXXXX";
        const string apiKeySecret = "your_api_key_secret";

        TwilioClient.Init(apiKeySid, apiKeySecret);

        var layout = new
        {
            grid = new
            {
                video_sources = new string[]{"*"}
            }
        };

        var compositionHook = CompositionHookResource.Create(
          friendlyName: "MyFirstCompositionHook",
          audioSources: new List<string>{"*"},
          videoLayout: layout,
          statusCallback: new Uri('http://my.server.org/callbacks'),
          format: FormatEnum.Mp4
        );

        Console.WriteLine($"Created Composition Hook with SID: {compositionHook.Sid}");
    }
}
