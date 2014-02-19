VentuzKissboxIO
===============

Hardware like Kissbox I/O8 and I/O3 can add a crazy amount of inputs to your Ventuz scene. 

#### Create the following inputs & outputs:

##### inputs

| type          | name          |
| ------------- |-------------|
| string      | response |

##### outputs

| type          | name          |
| ------------- |-------------|
| boolean array | Slot1 |
| boolean array | Slot1 |
| boolean array | Slot1 |
| boolean array | Slot1 |
| boolean array | Slot1 |
| boolean array | Slot1 || boolean array | Slot1 |

#### connect a string array to the script node:


![alt text](Http://sebastianspiegl.de/VentuzLoadSaveXML_connection.png "VentuzLoadSaveXML_connection.png")

#### troubleshooting:

|Error    | Solution |
|---------|-----|
|Check method Onload in Script Node Script... File "filename" could not be found |Either create your initial XML file manually OR invoke **_save_** first to create it from inside Ventuz.|
|Check method Onsave in Script Node Script... Access to path "filename" is denied|You haven't got the privilege to write to the path you provided. Use "C:\Users\ **_accountName_** \..." instead. |












