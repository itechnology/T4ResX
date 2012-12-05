T4ResX
======
Transform ResX files into strongly typed classes via T4

#### 2012-12-05
First commit. Now getting some docs ready !

Sample site up on Windows Azure @ [t4resx.azurewebsites.net](http://t4resx.azurewebsites.net/)

If it's, it might be normal ..it's running on a free instance with daily ressource limits

---

####Have a project that uses ResX files ?

- Transform all ResX files in a project into a strongly typed, compiled assembly
- Access your translations directly
   - From inside .cshtml & .aspx files
     - ``@Resources.User.Pseudo`` / ``<%= Resources.User.Pseudo %>``
- Bind your translations directly to a ViewModel
  - ``[Display(Name = "Pseudo", ResourceType = typeof(Resources.User))]``
- Use it again in your dlls to return localized error messages
  - ``return Resources.User.RegisterError;``

####Use variables inside your ResX files
- Format an error messages
  - .resx: ``Welcome {0}``
  - .cs &nbsp; : ``Resources.User.Welcome(Pseudo)``
- Dynamically replace variables
  - ``Register with {Domain}``
  - ``{Brand} announces new feature for {0}``

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