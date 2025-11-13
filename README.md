# Korean Nonsense "Waoh" Novel Generator (The Great Tale of Misono Mika in the Wonder World Generator)

A fun console application that generates nonsense novels using Korean interjections and exclamations, inspired by "ワオ(Waoh)" the iconic catchphrase of Blue Archive's popular character Mika Misono(feat. YooHee/K2 in Girls' Frontline Series).

## Requirements

- .NET 10.0 SDK or later
- Compatible operating system (Windows, macOS, or Linux)

## Building

1. Clone the repository
2. Navigate to the project directory
3. Run the following commands:

```bash
dotnet restore
dotnet build
dotnet run
```

## Features

- Randomly generates novels using Korean characters like "와", "아", "오", etc.
- Customizable length between 4,096 and 7,127 characters
- Automatically saves the generated novel to a text file
- Interactive console interface

## Implementation Details

- Initial character is randomly selected from "와", "아", "오"
- Character selection probabilities during generation:
- "와": around 30%
- "아": around 33%
- "오": around 33%
- Other characters appear with less than 1% probability each
- The novel always ends with an exclamation mark (!)

## Usage

1. Run the application
2. When prompted, type 'Y' to start generating a novel or 'N' to exit
3. The application will:
    - Generate a random-length novel
    - Display the novel in the console
    - Save the novel to 'WaohStory.txt' in the application directory

## Output

The generated novel is saved to `WaohStory.txt` in the same directory as the application.

## Characters Used

The generator uses the following Korean characters:

- 와, 아, 오, 앙, 옹, 왕, 이, 어, 잉, 엉, !
