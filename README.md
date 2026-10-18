# Bum to Winner

## Features

Game where the Player is starting as a Bum and tries to get voted as a President

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download) or later

### Installation

```bash
dotnet add package MyProject
```

Or clone and build from source:

```bash
git clone https://github.com/user/myproject.git
cd myproject
dotnet build
```

## Usage

```csharp
using MyProject;

var parser = new InvoiceParser();
var invoice = await parser.ParseAsync("invoice.xml");

if (!invoice.IsValid)
{
    foreach (var error in invoice.Errors)
        Console.WriteLine(error);
}
```

## Configuration

Add to `appsettings.json`:

```json
{
  "MyProject": {
    "StrictMode": true,
    "Culture": "en-US"
  }
}
```

## Project Structure

```
src/
  MyProject/          # Core library
  MyProject.Cli/      # Command-line tool
tests/
  MyProject.Tests/    # xUnit tests
```

## Running Tests

```bash
dotnet test
```

## Contributing

Contributions are welcome! Please read [CONTRIBUTING.md](CONTRIBUTING.md) first, then open an issue or pull request.

## License

This project is licensed under the MIT License. See [LICENSE](LICENSE) for details.
