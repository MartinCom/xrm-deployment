# xrm-deployment

Simple console app to update Dynamics CRM assemblies 

# --help

  -p, --path                Required. path for dll, C:/example/my.dll or my.dll

  -c, --connectionstring    Required. Connection string for Crm AuthType=IFD/OAuth/AD;Url=; Domain=; Username=;
                            Password=;

  -f, --fore                (Default: false) fore update dll (remove missing plugintypes (plugin class).

  -i, --isolationmode       Required. Isolation Mode:
                    None = 1,
                    Sandbox =
                            2,

  -s, --sourcetype          (Default: Database) Source Types:
                    Database = 0,

                            Disk = 1,
                    Normal = 2

  --help                    Display this help screen.

  --version                 Display version information.

