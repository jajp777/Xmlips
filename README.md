
# Xmlips - XML in PowerShell

The module provides cmdlets for basic operations on XML in PowerShell v2.0 or newer.

#### Read-Xml, Save-Xml, Import-Xml, Export-Xml

Cmdlets for reading and saving XML documents and fragments.

#### Get-Xml

Similar to `Select-Xml`. Main differences:

- input is nodes, paths are not supported
- output is nodes or PSObject, not node info
- it supports variables in XPath expressions
- it supports Property to get data as PSObject

#### Find-Xml

Gets an element specified by its name, key attribute name, and unique value.
If the element is not found then it is created with the key attribute value.

#### Add-Xml

Creates and adds a new element to the specified.

#### Set-Xml

Sets the specified attribute values.

#### Remove-Xml

Removes the specified nodes.

***
## Get and Install

Xmlips is distributed as the NuGet package [Xmlips](https://www.nuget.org/packages/Xmlips).
Download it to the current location as the directory *"Xmlips"* by this PowerShell command:

    Invoke-Expression "& {$((New-Object Net.WebClient).DownloadString('https://github.com/nightroman/PowerShelf/raw/master/Save-NuGetTool.ps1'))} Xmlips"

Alternatively, download it by NuGet tools or [directly](http://nuget.org/api/v2/package/Xmlips).
In the latter case save it as *".zip"* and unzip. Use the package subdirectory *"tools/Xmlips"*.

Copy the directory *Xmlips* to a PowerShell module directory, see
`$env:PSModulePath`, normally like this:

    C:/Users/<User>/Documents/WindowsPowerShell/Modules/Xmlips

***
## Example

- [Update-WebXml.ps1](https://raw.githubusercontent.com/nightroman/Xmlips/master/Examples/Update-WebXml.ps1)
