<p align="center" >
	<img src="/Images/logo_2048_600.png" alt="Wordy" title="Wordy">
</p>

<p align="center">
	<a href="https://http://www.android.com">
		<img src="https://img.shields.io/badge/.net framework-4.6.1-blue.svg?style=flat">
	</a>
	<a href="https://http://www.android.com">
		<img src="https://img.shields.io/badge/nuget-1.0-blue.svg?style=flat">
	</a>
	<a href="https://tldrlegal.com/license/apache-license-2.0-(apache-2.0)">
		<img src="https://img.shields.io/badge/License-Apache 2.0-blue.svg?style=flat">
	</a>
</p>

## At a Glance

`Wordy` is a powerful text processor that provides an easy way to manage content in `String` object.

## How to Get Started

Use `NuGet`.

## Requirements

.NET Framework 4.6.1.

## Usage

Everything starts with `UseWordyTo` prefix. This is your entry point to all tools provided by the library.

### Text Effects

Let's start with a very simple example of text effect:

```c#
string filteredText = UseWordyTo.MakeEffects("Hi!")
    .Apply(new InversionEffect())
    .GetResult();

Console.WriteLine(filteredText); // "!iH"
```

This is how it works: `UseWordyTo.MakeEffects(...)` gives you an `EffectManager` instance configured for your source text. Then, you can apply some effects and retrieve the final text by `.GetResult()` call.

In the example above, the `InversionEffect` will be applied to the entire string. The same time, you can apply effect to a particular substring:

```c#
String filteredText = UseWordyTo.MakeEffects("Hi!")
    .Apply(new InversionEffect(), 0, 1) // Start index is 0, end index is 1
    .GetResult();

Console.WriteLine(filteredText); // "iH!"
```

You can add as many effects as you want:

```c#
String filteredText = UseWordyTo.MakeEffects("This text will be rotated")
    .Apply(new RotationEffect(TextRotation.Inverted))
    .Apply(new InversionEffect())
    .GetResult();

Console.WriteLine(filteredText); // "рǝʇɐʇоɹ ǝq llıм ʇxǝʇ sıɥʇ"
```

#### Case Effect

Represented by `CaseEffect` class. Changes case for the entire text or letters at particular positions.

Constructor example:

```c#
new CaseEffect(TextCase.FirstUpperNextLower)
```

[`TextCase`](#text-case) is the only setting that defines `CaseEffect`'s behavior.

#### Rotation Effect

Represented by `RotationEffect` class. Rotates letters. For example,

`p` becomes `d`

and

`h` becomes `ɥ`.

`RotationEffect` has two available constructors. The most detailed version of constructor:

```c#
new RotationEffect(TextRotation.Inverted, true)
```

The first parameter is a [`TextRotation`](#text-rotation) value that defines the way to rotate symbols.

The second parameter of boolean type defines whether the rotation alrorithm should be case sensitive. If it equals to `false`, some uppercased symbols might become lowercased as a result of rotation.

The second constructor is a simplified version of the first one:

```c#
new RotationEffect(TextRotation.Inverted)
```

It's case sensitive by default. Usually, it's enough to use the second constructor excepting cases when you need more flexibility.

#### Inversion Effect

Represented by `InversionEffect` class. Flips text from right to left, so

`Hi!`

turns into

`!iH`

`InversionEffect`'s constructor is very simple and doesn't require any parameters:

```c#
new InversionEffect()
```

### Transliteration

Example of transliteration:

```c#
String transliterated = UseWordyTo.Transliterate
(
    Language.Russian,    // from Russian
    Language.English     // to English
).GetText("Привет!");

Console.WriteLine(transliterated); // "Privet!", which means "Hi!"
```

Currently supported languages are:

- English
- Russian

### Options

#### Text Case

`TextCase` is used as a setting for `CaseEffect` instance. Available values are:

- `AllUpper`: Makes the entire text uppercased.
- `AllLower`: Makes the entire text lowercased.
- `FirstUpperNextLower`: First symbol is uppercased, other text is lowercased.
- `FirstLowerNextUpper`: First symbol is lowercased, other text is uppercased.
- `AlternatingFirstUpperCase`: Odd symbols are uppercased, even symbols are lowercased.
- `AlternatingFirstLowerCase`: Odd symbols are lowercased, even symbols are uppercased.

#### Text Rotation

`TextRotation` defines the conditions of symbol rotation. Available values:

- `Normal`: Forces all symbols to be rotated to normal position. It means that `ʎ` would become `y` and `h` would stay `h`.
- `UpsideDown`: Forces all symbols to be rotated upside down. In this case, `y` would turn into `ʎ`, but `ɥ` wouldn't change at all.
- `Inverted`: Normal symbols are forced to be rotated meanwhile rotated symbols become normal. So, `y` becomes `ʎ` and `ɥ` turns into `h`.

#### Language

The `Language` type is used for transliterations. Possible values:

- `English`
- `Russian`

### Plugins

You can extend the functionality of `Wordy` without making changes to the library. Instead of sending pull request, simply create your own plugin.

Each plugin is a subclass of the abstract class named `Plugin`. Take a look at the example below:

```c#
class Repeat : Plugin
{
    public Repeat(string sourceText) : base(sourceText)
    {
    }

    public override string GetResult()
    {
        return this.SourceText + this.SourceText;
    }
}
```

This is a plugin that repeats the source text two times. All that you need to implement is:

- overrided constructor that takes `sourceText` parameter of `String` type;
- `GetResult()` method that returns `String` with filtered text.

The core of your plugin's implementation is the `GetResult()` method, inside of which you can implement any logic. To access the source text, simply use `this.SourceText`.

Now let's try to use the plugin:

```c#
String repeatedText = UseWordyTo.IntegratePlugin<Repeat>("Test.")
    .GetResult();
Console.WriteLine(repeatedText); // "Test.Test."
```

As you can see, creating and using plugins for `Wordy` is quite easy. You can publish your plugins as separate library or send as a pull request if you want it to be included in the library after reviewal process.

## License

`Wordy` is available under the Apache 2.0 license. See the [LICENSE](./LICENSE) file for more info.
