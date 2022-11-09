using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Lesson;

namespace Benchmark
{
    [MemoryDiagnoser]
    [RankColumn]
    public class MyParserBenchmark
    {
        private const string STRING_TO_PARSE_WITH_ERROR = "qwert22";
        private const string STRING_TO_PARSE = "54";

        private readonly MyParser _myParser = new MyParser();

        [Benchmark]
        public void TryCatchParse_Test_WithError()
        {
            int result = _myParser.TryCatchParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]
        public void TryParse_Test_WithError()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE_WITH_ERROR);
        }

        [Benchmark]
        public void TryParseFixed_Test_WithError()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE_WITH_ERROR);
        }
        
        [Benchmark]
        public void TryParseFixed_V2_Test_WithError()
        {
            int result = _myParser.TryParseFixed_V2(STRING_TO_PARSE_WITH_ERROR);
        }
        // -----------------------##################_----------------------
        [Benchmark]
        public void TryCatchParse_Test()
        {
            int result = _myParser.TryCatchParse(STRING_TO_PARSE);
        }

        [Benchmark]
        public void TryParse_Test()
        {
            int result = _myParser.TryParse(STRING_TO_PARSE);
        }
        
        [Benchmark]
        public void TryParseFixed_Test()
        {
            int result = _myParser.TryParseFixed(STRING_TO_PARSE);
        }

        [Benchmark]
        public void TryParseFixed_V2_Test()
        {
            int result = _myParser.TryParseFixed_V2(STRING_TO_PARSE);
        }

    }
}
