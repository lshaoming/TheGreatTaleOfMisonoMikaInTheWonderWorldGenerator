namespace Waoh;

internal class NovelGenerator
{
    private readonly string[] _waoh = ["와", "아", "오", "앙", "옹", "왕", "이", "어", "잉", "엉", "!"];
    private readonly Random _random = new();
    private static readonly string Br = Environment.NewLine;
    private const string OutputFileName = "WaohStory.txt";

    public void Start()
    {
        if (!AskIfStartNovel()) return;
        PrintMessage("와오! 시작할게요!");
        GenerateNovel();
        QuitProgram();
    }

    private static bool AskIfStartNovel()
    {
        while (true)
        {
            Console.Write("와오! 소설을 작성하겠습니다. 시작할까요? (Y/N) : ");
            var choice = Console.ReadLine()?.ToLower();
            Console.WriteLine();

            switch (choice)
            {
                case "y":
                    return true;
                case "n":
                    return false;
                default:
                    PrintMessage("와오! 잘못 입력하셨어요!");
                    break;
            }
        }
    }

    private void GenerateNovel()
    {
        long countI = 0;
        var count = _random.NextInt64(4096, 7127);
        var waohString = _waoh[_random.Next(0, 3)];

        PrintMessage($"작성할 글자 수는 {count}자에요! 와오하게 많네요!{Br}");
        PrintMessage("작성한 소설 :");
        Console.Write(waohString);

        GenerateNovelContent(ref waohString, count, ref countI);
        EnsureEndsWithExclamation(ref waohString);
        SaveToFile(waohString);

        PrintMessage($"{Br}{Br}" +
                     $"와오! 소설 작성이 끝났어요! {OutputFileName} 파일에 저장되었으니 확인해주세요! 와오!");
    }

    private void GenerateNovelContent(ref string waohString, long count, ref long countI)
    {
        do
        {
            var randNum = DetermineRandomCharacterIndex(waohString);
            Console.Write(_waoh[randNum]);
            waohString += _waoh[randNum];

            if (randNum == 10)
            {
                Console.Write(" ");
                waohString += " ";
            }

            countI++;
        } while (countI < count);
    }

    private void EnsureEndsWithExclamation(ref string waohString)
    {
        if (waohString.EndsWith('!')) return;
        Console.Write(_waoh[^1]);
        waohString += _waoh[^1];
    }

    private static void SaveToFile(string content)
    {
        File.WriteAllText(OutputFileName, content);
    }

    private int DetermineRandomCharacterIndex(string waohString)
    {
        var randPers = _random.Next(0, waohString.EndsWith(' ') ? 103 : 113);
        return randPers switch
        {
            >= 0 and < 30 => 0,
            >= 30 and < 63 => 1,
            >= 63 and < 96 => 2,
            96 => 3,
            97 => 4,
            98 => 5,
            99 => 6,
            100 => 7,
            101 => 8,
            102 => 9,
            _ => 10
        };
    }

    private static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    private static void QuitProgram()
    {
        Console.WriteLine("아무 키나 눌러서 종료해요!");
        Console.ReadKey();
        Console.WriteLine("와오!");
    }
}