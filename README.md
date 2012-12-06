T4ResX
======
Transform ResX files into strongly typed classes via T4

####[Consult Documentation](https://github.com/itechnology/T4ResX/wiki)

##Download
 * [Nuget Package](https://nuget.org/packages/T4ResX)
 * [Visual Studio Extension](http://visualstudiogallery.msdn.microsoft.com/8b008710-a354-4503-b70d-784493114d5d)
 * [Single File](https://raw.github.com/itechnology/T4ResX/master/T4ResX.tt)
 * [Sample Solution](https://github.com/itechnology/T4ResX/archive/master.zip)


#Overview

##Have a project that uses ResX files ?

- Transform ResX files in a project into a strongly typed assembly
- Access your translations
   - From inside .cshtml & .aspx files
     - ``@Resources.User.Pseudo`` / ``<%= Resources.User.Pseudo %>``
- Bind your translations to a ViewModel
  - ``[Display(Name = "Pseudo", ResourceType = typeof(Resources.User))]``
- Use it again in your dlls to return localized error messages
  - ``return Resources.User.RegisterError;``

####Use variables inside your ResX files
- Format various messages
  - .resx: ``Welcome {0}``
     - .cs: ``return Resources.User.Welcome("Robert")``
     - result: ``Welcome Robert``
- Dynamically replace variables
  - .resx: ``Register with {DOMAIN}``
     - .cs: ``return Resources.Branding.Register;`` 
     - result: ``Register with www.i-technology.net`` 
  - .resx: ``{BRAND} announces new feature for {0}``
     - .cs: ``return Resources.Branding.Feature("T4")``
     - result: ``I-Technology announces new feature for T4``

####Export & Reuse your translations
- Pull translations directly into localized JavaScript files
  - ``<script src="/GetNameSpaceAsJs?ns=Resources.User"></script>``
- Or assign inline
  - ``var localized = GetNameSpaceAsJson("Resources.User");``
- Grab a series of translations as collection
  - ``Dictionary<string, Dictionary<string string>> items = GetResourcesByNameSpace("Resources.User");``
- Or do just grab bits & pieces
  - ``Dictionary<string, Dictionary<string string>> items = GetResourcesByNameSpace(".*");``
  - ``Dictionary<string, Dictionary<string string>> items = GetResourcesByNameSpace("Resources.User.*");``
  - ``Dictionary<string, Dictionary<string string>> items = GetResourcesByNameSpace("^User|Branding");``

##Updates

###0.99 / 2012-12-05
* First commit.
* Sample site up on Windows Azure @ [t4resx.azurewebsites.net](http://t4resx.azurewebsites.net/)
* If it's down, it might be normal ..running on a free instance with daily resource limits