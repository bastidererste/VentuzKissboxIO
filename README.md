VentuzKissboxIO
===============

Hardware like Kissbox I/O8 and I/O3 can add a crazy amount of inputs to your Ventuz scene. on an input change the box fires an UDP message that has the following protocol: comand-slot-input-state. As Ventuz4 has no UDP in node you have to use f.e. eltimas serial to ethernet connector to connect the UDP ip:port to a comport. This Script generates 8 boolean arrays that hold 8 input states each.  

#### Create the following inputs & outputs:

##### inputs

| type          | name          |
| ------------- |-------------|
| string      | response |

##### outputs

| type          | name          |
| ------------- |-------------|
| boolean array | Slot1 |
| boolean array | Slot2 |
| boolean array | Slot3 |
| boolean array | Slot4 |
| boolean array | Slot5 |
| boolean array | Slot6 |
| boolean array | Slot7 |
| boolean array | Slot8 |

connect the response of the comport node to the response of this script node. Also, connect one array indexer node to each of the boolean arrays in the output. 

#### precautions
This code is provided as is! 
It takes no care of malformed messages as there is no crc provided in the given protocol.

#### troubleshooting:

|Error    | Solution |
|---------|-----|










