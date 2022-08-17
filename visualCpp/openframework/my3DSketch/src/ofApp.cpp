#include "ofApp.h"

void ofApp::setup(){
	image.load("stars.png");
    image.resize(200, 200);

    mesh.setMode(OF_PRIMITIVE_POINTS);
    mesh.enableColors();

    float intensityThreshold = 150.0;
    int w = image.getWidth();
    int h = image.getHeight();
    for (int x = 0; x < w; ++x) {
        for (int y = 0; y < h; ++y) {
            ofColor c = image.getColor(x, y);
            float intensity = c.getLightness();
            if (intensity >= intensityThreshold) {
                float saturation = c.getSaturation();
                float z = ofMap(saturation, 0, 255, -100, 100);
                ofVec3f pos(x * 4, y * 4, z);
                mesh.addVertex(pos);
                mesh.addColor(c);
            }
        }
    }

    mesh.setMode(OF_PRIMITIVE_LINES);
    mesh.enableIndices();

    float connectionDistance = 30;
    int numVerts = mesh.getNumVertices();
    for (int a = 0; a < numVerts; ++a) {
        ofVec3f verta = mesh.getVertex(a);
        for (int b = a + 1; b < numVerts; ++b) {
            ofVec3f vertb = mesh.getVertex(b);
            float distance = verta.distance(vertb);
            if (distance <= connectionDistance) {
                // In OF_PRIMITIVE_LINES, every pair of vertices or indices will be
                // connected to form a line
                mesh.addIndex(a);
                mesh.addIndex(b);
            }
        }
    }
}

void ofApp::draw(){
    ofColor centerColor = ofColor(85, 78, 68);
    ofColor edgeColor(0, 0, 0);
    ofBackgroundGradient(centerColor, edgeColor, OF_GRADIENT_CIRCULAR);

    easyCam.begin();
    ofPushMatrix();
    ofTranslate(-ofGetWidth() / 2, -ofGetHeight() / 2);
    mesh.draw();
    ofPopMatrix();
    easyCam.end();
}

void ofApp::mouseDragged(int x, int y, int button){
}

void ofApp::mousePressed(int x, int y, int button){
}

void ofApp::update() {
    
}
