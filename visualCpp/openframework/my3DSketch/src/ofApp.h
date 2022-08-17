#pragma once

#include "ofMain.h"

class ofApp : public ofBaseApp{
	public:
		void setup();
		void draw();
		void update();
		void mouseDragged(int x, int y, int button);
		void mousePressed(int x, int y, int button);

		ofMesh mesh;
		ofImage image;
		ofEasyCam easyCam;
};
