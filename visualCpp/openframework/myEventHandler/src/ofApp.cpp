#include "ofApp.h"

// ofSort에게 두 아이템을 어떻게 비교할것인지 알려주는 boolean 함수
bool sortMe(sortObj& a, sortObj& b) {
    if (a.getAge() < b.getAge()) { return true; }
    else { return false; }
}

//--------------------------------------------------------------
void ofApp::setup(){
    sortObj a( 1, 980 );
    sortObj b( 2, 14 );
    sortObj c( 3, 45 );
    sortObj d( 4, 38 );
    sortObj e( 5, 74 );

    vector<sortObj> objects = { a, b, c, d, e };

    cout << "정렬 전 :: " << endl;
    for (auto& atom : objects) {
        cout << atom.getId() << " : " << atom.getAge() << endl;
    }
    
    ofSort(objects, sortMe);

    cout << "정렬 후 :: " << endl;
    for (auto& atom : objects) {
        cout << atom.getId() << " : " << atom.getAge() << endl;
    }
}

//--------------------------------------------------------------
void ofApp::update(){

}

//--------------------------------------------------------------
void ofApp::draw(){

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
	ofLogNotice() << "x: " << x << ", y: " << y << ", clicked: " << button;
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
