#pragma once

#include "ofMain.h"
#include "ofxCinderTimeline.h"

class ofApp : public ofBaseApp {

public:
	void setup();
	void update();
	void draw();

	void mousePressed(int x, int y, int button);
	ofxCinderTimeline::Timeline& timeline() { return *mTimeline; }
private:
	std::shared_ptr<ofxCinderTimeline::Timeline> mTimeline;
	ofxCinderTimeline::Anim<ofPoint> mBlackPos, mWhitePos;
};
