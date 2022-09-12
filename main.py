import serial
#import pyserial

def main():
    print("Test")
    debug = read_torque()
    #debug = "test"
    print(debug)
    return debug




def read_torque():
    import serial
    COM_PORT = "COM15"
    BAUD_RATE = 115200
    try:
        actuator = serial.Serial(port=COM_PORT, baudrate=BAUD_RATE)
        print(f"Device Found at Port {COM_PORT}. ")
        print(actuator.is_open)
    except:
        print(f"No device found at Port {COM_PORT}. ")
        return f"No device found at Port {COM_PORT}. "
    try:
        actuator.write("0x2500:02\r\n")
        readSomeByte = ""
        while actuator.is_open:
            readSomeByte = actuator.read(8)
        print(readSomeByte)
    except:
        print(f"Device Failed to Respond")
        return "Device failed to respond"
    try:
        actuator.close()
        print(actuator.is_open)
        return "Success"
    except:
        print("No open com port found")
        return "No Open Com Port Found"



'''
| Object 			|Use					| Index | Sub-Index | Range_min | Range_max | Value |
|---				|---					|---	|---		|---		|---		|---	|
|Torque Actual Value|						|6077	| 00		| 0			| 1000		|		|
|NanoJ Output #2	|Torque Percent (User)	|2500	| 02		| 0			| 100		|		|
|NanoJ Output #1	|Analog Input (Speed)	|2500	| 01		| 0			| 100		|		|

'''


def attempt_com():
    try:
        actuator = serial.Serial(port=COM_PORT, baudrate=9600)
        print(f"Device Found at Port {COM_PORT}. ")
        return actuator
    except:
        print(f"No device found at Port {COM_PORT}. ")
        return False

def TEST_toggle_actuator():
    try:
        actuator.write(b"GO\r\n")
        return True
    except:
        print(f"Device Failed to Respond")
        return False


def close_com():
    actuator.close()


if __name__ == '__main__':
    main()


