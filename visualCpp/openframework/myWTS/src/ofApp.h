#pragma once

#include "ofMain.h"

class ofApp : public ofBaseApp, public ofThread {

	public:
		void setup();
		void update();
		void draw();

		void exit();
		void threadedFunction();
		ofTrueTypeFont font;
		vector <string> words;
		int step;
};
