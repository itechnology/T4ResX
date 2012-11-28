T4ResX
======
Transform ResX files into strongly typed classes via T4


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
  - ``Register with [[Domain]]``
  - ``[[Brand]] announces new feature``

####Export & Reuse your translations
- Pull translations directly into localized JavaScript files
  - ``<script src="/GetResources?ns=Resources.User"></script>``
- Grab a series of translations as collection
  - ``Dictionary<string string> items = GetResourceSetAsDictionary("Resources.User");``

- - -

#### 2012-11-28
Currently rewriting/cleaning up code, should be out within a week or so

_Yes, all the above functionaly is existant & working ;-)_