#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){
	font.load("HMFMMUEX.TTC", 34);

	string lyrics = ofBufferFromFile("lyrics.txt").getText();
	step = 0;
	words = ofSplitString(lyrics, " ");

	startThread();
}

//--------------------------------------------------------------
void ofApp::threadedFunction() {
	while (isThreadRunning()) {
		string cmd = "data\\SayStatic.exe " + words[step];

		cout << cmd << endl;
		ofSystem(cmd.c_str());
		step++;
		step %= words.size();
		//ofSleepMillis(2);
	}
}

//--------------------------------------------------------------
void ofApp::update(){

}

//--------------------------------------------------------------
void ofApp::draw(){
	float x = (ofGetWidth() - font.stringWidth(words[step])) / 2;
	float y = ofGetHeight() / 2;
	ofSetColor(0);
	font.drawString(words[step], x, y);
}

//--------------------------------------------------------------
void ofApp::exit() {
	waitForThread(true);
}