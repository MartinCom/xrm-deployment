# xrm-deployment

Simple console app to update Dynamics CRM assemblies 

# Usage

Xrm.Demployment.Console.exe --c "AuthType=<authOption>;Url=<crmurl>; Domain=<Domain>; Username=<User>; Password=<Password>;" --i 2 --path Xrm.ExamplePlugin.dll
or
Xrm.Demployment.Console.exe if file xrm-deployment-config.json is present, first configuration item is used.

 Results:
 
Start update assembly
Updated plugins : 3
Created plugins : 0
Removed plugins : 0
Finished in  0:00:00,6633709

# --help
result:
Xrm.Demployment 1.0.1.0
Copyright c  2018

  -p, --path                path for dll, C:/example/my.dll or my.dll

  -e, --switchconfig        Name of configuration elment to be processed by application

  -c, --connectionstring    Connection string for Crm AuthType=IFD/OAuth/AD;Url=; Domain=; Username=; Password=;

  -f, --force               (Default: false) fore update dll (remove missing plugintypes (plugin class).

  -i, --isolationmode       Isolation Mode:
                    None = 1,
                    Sandbox = 2,


  -s, --sourcetype          (Default: Database) Source Types:
                    Database = 0,
                    Disk = 1,
                    Normal = 2

  --help                    Display this help screen.

  --version                 Display version information.



  
# Config File 
{
  "Default": {
    "connectionString": "AuthType=Office365;Url=; Username=; Password=;",
    "force": false,
    "isolationmode": 2,
    "path": "Xrm.ExamplePlugin.dll",
    "sourcetype": 0
  },
  "Default2": {
    "connectionString": "",
    "force": false,
    "isolationmode": 2,
    "path": ""
  }
}

