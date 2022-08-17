#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){
    mTimeline = ofxCinderTimeline::Timeline::create();
    mTimeline->stepTo(ofGetElapsedTimef());

    mBlackPos = mWhitePos = ofGetWindowSize() / 2.0;
}

//--------------------------------------------------------------
void ofApp::update(){
    mTimeline->stepTo(ofGetElapsedTimef());
}

//--------------------------------------------------------------
void ofApp::draw(){
    ofSetColor(ofColor::black);
    ofFill();
    ofCircle(mBlackPos, 20.0f);
    

    ofSetColor(ofColor::white);
    ofFill();
    //ofCircle(mWhitePos, 16.0f);
}

//--------------------------------------------------------------
void ofApp::mousePressed(int x, int y, int button){
    timeline().apply(&mBlackPos, ofPoint(x, y), 2.0f, ofxCinderTimeline::EaseInOutCubic());
    timeline().apply(&mWhitePos, ofPoint(x, y), 0.35f, ofxCinderTimeline::EaseOutQuint()).appendTo(&mBlackPos);
}