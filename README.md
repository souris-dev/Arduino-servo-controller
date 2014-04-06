Arduino Servo Controller
===================
-------------------------------

About
-------

This is a Windows Form Application that is programmed in C#.NET. 
It is used to control the servos that are connected to the PWM pins on an Arduino Mega or Uno.
It uses the serial to communicate with the Arduino on a specified COM port.
In case of Mega, there are 13 PWM pins, and 3 or 4 PWM pins on an Arduino Uno.

This application can find its usage in controlling servo-controlled robots, like humanoids.

Getting Started
---------------------

**Note**: The software has not been thoroughly tested yet. **Use at your own risk.**

1. Download the ZIP file, or checkout/clone the repo.
2. Open the Solution in you Visual Studio IDE (best to use 2012, others may/may not work, express will work).
3. Build the whole solution.
4. Upload the sketch "RemoteCont.ino" onto the Arduino Mega/Uno using the Arduino IDE.
5. Note the serial COM port on which the Arduino is present.
6. Use the application.
 
Version Information
---------------------
**v1:**
* Provides basic servo control (only using Mega).

**v2:**
* Fixed resize issue
* Improved the user interface
* More fixes have been made
* Improved servo control (in code)

**v3 (coming soon):**
* Actions and frames will be added
* User will be able to save the actions in a file

Contact Information
------------------------

Contact e-mail of author:
[suorees113@gmail.com](mailto:suorees113@gmail.com)

Suggestions, contributions and opinions are always welcome.

License
-----------

See *LICENSE* file.
