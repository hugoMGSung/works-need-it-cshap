#include "ofApp.h"

//--------------------------------------------------------------
void ofApp::setup(){
	value.set("value", 0.2, 2, 10);
	gui.setup();
	gui.add(value);
	//int fontsize = 30;
	//font.load("MAGNETOB.TTF", fontsize); // /bin/data 폴더에 폰트 복사
	//font.load("MAGNETOB.TTF", fontsize+50);
	//font.setLetterSpacing(2); // 글자 공백
}

//--------------------------------------------------------------
void ofApp::update(){

}

//--------------------------------------------------------------
void ofApp::draw(){
	gui.draw();
	//ofSetColor(0xFF0000); // RGB
	//font.drawString("Hello World!", 100, 230);
}

//--------------------------------------------------------------
void ofApp::keyPressed(int key){

}

//--------------------------------------------------------------
void ofApp::keyReleased(int key){

}

//--------------------------------------------------------------
void ofApp::mouseMoved(int x, int y ){

}

//--------------------------------------------------------------
void ofApp::mouseDragged(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mousePressed(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseReleased(int x, int y, int button){

}

//--------------------------------------------------------------
void ofApp::mouseEntered(int x, int y){

}

//--------------------------------------------------------------
void ofApp::mouseExited(int x, int y){

}

//--------------------------------------------------------------
void ofApp::windowResized(int w, int h){

}

//--------------------------------------------------------------
void ofApp::gotMessage(ofMessage msg){

}

//--------------------------------------------------------------
void ofApp::dragEvent(ofDragInfo dragInfo){ 

}
