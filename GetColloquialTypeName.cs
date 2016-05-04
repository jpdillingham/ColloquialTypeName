/// <summary>
/// Returns a "pretty" string representation of the provided Type;  specifically, corrects the naming of generic Types
/// and appends the type parameters for the type to the name as it appears in the code editor.
/// </summary>
/// <param name="type">The type for which the colloquial name should be created.</param>
/// <returns>A "pretty" string representation of the provided Type.</returns>
private static string GetColloquialTypeName(Type type)
{
    return (!type.IsGenericType ? type.Name : type.Name.Split('`')[0] + "<" + String.Join(", ", type.GetGenericArguments().Select(a => GetColloquialTypeName(a))) + ">");
}
