// ==========================================================================
// TECHNICAL WORKSHOP - DEBUGGING LIKE A PRO!
//
// GOAL OF THIS SKETCH IS:
// EVERY TIME WE CLICK THE MOUSE,
// WE WANT TO CREATE A BUNCH OF RANDOM POINTS ON SCREEN!
// the colours should change smoothly with the mouse position
// it's not working though :((
// Can you fix it?
// ==========================================================================

// Resizable array to hold our points
// https://processing.org/reference/ArrayList.html
ArrayList<Point> points;

// how many points we want to draw
int numPoints = 100;

void setup() {
  
  // set drawing parameters for this sketch
  size(960, 720);     // window size
  strokeWeight(10);   // point size (well, stroke width actually)

}


void draw() {
  
  // draw the background in black
  background(0);

  // draw all the points on screen  
  for (int i = 0; i < points.size(); i++) {
  
    // get point number i from the list
    Point p = points.get(i);

    // use cool random colors
    stroke(mouseX % 256, mouseY % 256,random(255));
    
    // draw it on screen!
    point(p.x, p.y)
  }
  
}



void mouseClicked() {

  for (int i = 0; i < numPoints; i++) {

    points = new ArrayList(); //<>//

    Point p = new Point();
    p.x = (int)random(width);
    p.y = (int)random(width);

    points.append(p);
  }
}


class Point
{
  int x;
  int y;
}
