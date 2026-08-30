[![](https://img.shields.io/nuget/v/soenneker.quark.enums.textalignments.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.textalignments/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textalignments/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textalignments/actions/workflows/publish-package.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textalignments/build-and-test.yml?label=Build&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textalignments/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.quark.enums.textalignments.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.quark.enums.textalignments/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.quark.enums.textalignments/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.quark.enums.textalignments/actions/workflows/codeql.yml)

# Soenneker.Quark.Enums.TextAlignments

Strongly typed Tailwind text-alignment utility classes for Quark components.

## Install

```bash
dotnet add package Soenneker.Quark.Enums.TextAlignments
```

## Usage

```csharp
TextAlignmentEnum alignment = TextAlignmentEnum.Center;
string cssClass = alignment.Value; // "text-center"
```

The values are complete utility class names, so append `.Value` directly to a class list. They are not raw CSS `text-align` values.

Prefer `Start` and `End` when alignment should follow the document’s writing direction. Use `Left` and `Right` only when a physical side is required.

## Values

| Member | Utility class |
| --- | --- |
| `Left` | `text-left` |
| `Start` | `text-start` |
| `Center` | `text-center` |
| `End` | `text-end` |
| `Right` | `text-right` |
| `Justify` | `text-justify` |
