namespace CBT.Helpers;

using System;
using System.IO;
using Newtonsoft.Json;

/// <summary>
/// ManifestManager loads the Plugin manifest from the assembly directory.
/// </summary>
internal class ManifestManager : IDisposable
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ManifestManager"/> class.
    /// </summary>
    /// <param name="manifestPath">Path to the Assembly directory where manifest is located.</param>
    internal ManifestManager(string manifestPath)
    {
        this.Manifest = JsonConvert.DeserializeObject<Manifest>(File.ReadAllText(manifestPath)) ?? new Manifest();
    }

    /// <summary>
    /// Gets the PluginManifest.
    /// </summary>
    internal Manifest? Manifest { get; private set; }

    /// <inheritdoc/>
    public void Dispose()
    {
    }
}