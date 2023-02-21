# Mathink

Inkscape math symbols / formula editor with latex/tex syntax. **Latex Env not required.**


![](https://i.imgur.com/YcYaaU2.jpg)

## Modifications
This repo is forked one, please refer to the original repo first.

Here, find a list of the modifications/additions made from the original work:
* The GUI has been translated into English and all the code variables have also been.
* The formula can be copied to the clipboard in the SVG format.

## Usage

Download `extensions.zip` from `Release`. Unzip files to extensions folder for Inkscape, for me it is  `C:\Program Files\Inkscape\share\inkscape\extensions`. After doing so, `mathink.ink` will be in the same directory level of other `inx` files. Relaunch Inkscape.

On Inkscape started, click menu item `Extra->Mathink...`

For the first time to click `Apply`, the main window of Mathink will appear. Now type some formula expressions in the first textbox, and click `Apply` again, you will see the formula is appened to current layer of Inkscape. The Latex formula can be saved as PNG, SVG, and text file. It can also be copied to the clipboard.

## Requirement

Inkscape 0.9x is no longer supported. Require >= 1.0

Python and some libs:
* inkex
* cssselect
* lxml

## Release

v1.1 (original): https://github.com/pluveto/Mathink/releases
v1.2 (mine version): 
