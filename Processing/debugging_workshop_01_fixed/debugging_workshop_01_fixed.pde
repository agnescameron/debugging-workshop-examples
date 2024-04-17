// ==========================================================================
// TECHNICAL WORKSHOP - DEBUGGING LIKE A PRO!
//
// GOAL OF THIS SKETCH IS: EVERY TIME WE CLICK THE MOUSE,
// WE WANT TO CREATE 'numPoints' NUMBER OF RANDOM POINTS ON SCREEN!
// it's fixed now!!
//
// ==========================================================================

// Resizable array to hold our points
// https://processing.org/reference/ArrayList.html
ArrayList<Point> points;

// how many points we want to draw
int numPoints = 100;

void setup() {
  
  // set drawing parameters for this sketch
  size(960, 720);
  strokeWeight(10);

  // initialize the points list, so it is not NULL when first used in the draw loop
  points = new ArrayList();
}


void draw() {
  
  // draw the background in black
  background(0);
  
  // draw all the points on screen
  for (int i = 0; i < points.size(); i++) {

    Point p = points.get(i);
  
    stroke(mouseX % 256, mouseY % 256,random(255));
    point(p.x, p.y);
  }
  
}


void mouseClicked() {

  // clear the old points before we add any new ones
  points.clear();
  
  // generate numPoints number of new points
  for (int i = 0; i < numPoints; i++) {
    
    // create new Point with a random position (within the sketch window)  
    Point p = new Point();
    p.x = (int)random(width);
    p.y = (int)random(height);

    // add the new point to the list
    points.add(p);
  }
}

// a class to hold 2D pixel coordinates
class Point
{
  int x;
  int y;
}
