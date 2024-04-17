// CODE COURTESY OF NATASHA HUSAIN
// EDITED BY LIEVEN VAN VELTHOVEN
// BASED ON https://en.wikipedia.org/wiki/Tinkerbell_map
 

//variable setup - these are the values that are later factored into the equations //<>//
//the values asigned to the variables have been taken from https://en.wikipedia.org/wiki/Tinkerbell_map
float a = 0.9;
float b = -0.6013;
float c = 2;
float d = 0.5;
float startX = -0.72;
float startY = -0.64;
float bMove = -0.6013;
float dMove = 0.5;

int numberOfPoints = 50000;

 
void setup() {
  size(960, 720);
  background(0);

  println("mouse pos: "+ mouseX + ", " + mouseY);
}


void draw() {
  background(0);
  stroke(255);
  strokeWeight(1);

  // Moving the mouse changes two of the parameters used to create the points on screen.
  // Move your mouse and see what pretty patterns appear!
  float mappedMouseX = map(mouseX, 0, width, -0.8, -.4);
  float mappedMouseY = map(mouseY, 0, height, 0, 1);

  // The starting point
  Point startingPoint = new Point();
  startingPoint.x = startX;
  startingPoint.y = startY;

  // Call the Tinkerbell function to generate 50000 points; based on our starting point, mouse position and a couple of other parameters.
  Point[] points = Tinkerbell(a, mappedMouseX, c, mappedMouseY, startingPoint, numberOfPoints);

  // Draw the points onto the screen!
  for (var i = 1; i < points.length; i++) {
    point(points[i].x, points[i].y);
  }
}



// This function takes one point, adds it to the list, and then uses it to create the next point.
// It then uses that new point to create the next, etc., etc. It repeats this process 'numPoints' number of times.
// When it's done, we should have 'numPoints' number of points in our array.
// (in the Draw() function we actually draw the points on screen)
Point[] Tinkerbell(float a, float mappedMouseX, float c, float mappedMouseY, Point p0, int numPoints) {

  //create an empty array, which will get filled with points in the for loop below
  Point[] points = new Point[numPoints];

  //first point is added to the empty point array
  Point p1 = new Point(p0.x, p0.y);
  // map the positions to make the result look better on screen(?)
  p1.Map();
  // add it at position 0
  points[0] = p1;

  //starting point X and Y values
  var x = p0.x;
  var y = p0.y;

  // generate 'numPoints' number of points, according to the Tinkerbell equations and our parameters
  for (var i = 0; i < numPoints; i++) {

    if (mouseX != 0 && mouseY != 0)
    {
      println(x + ", " + y);
    }

    // save our previous point coordinates; we are going to need them in a second
    var previousX = x;
    var previousY = y;

    // calculate new X and Y values based on previous X and Y values:
    x = previousX * previousX - previousY * previousY + a * previousX + mappedMouseX * previousY;
    y = 2 * previousX * previousY + c * previousX + mappedMouseY * previousY;

    // create a new point to store in our list of points, at x y coordinates.
    Point p = new Point(x,y);
    p.Map();
    
    // add it to the array
    points[i] = p;

    //if (Float.isNaN(p.x))
    //{
    //  println("nan found");
    //}
  }

  //array - list of the points based on the number of iterations
  return points;
}


// ===================================================

// Defining the Point class
public class Point {
  public float x;
  public float y;

  // create new point with 0 coordinates
  public Point() {
    x = y = 0;
  }

  // create new Point at specified x,y position 
  public Point(float X, float Y) {
    x = X;
    y = Y;
  }

  // move and stretch the coordinates a bit
  public void Map()
  {
    x = map(x, -1.3, 0.5, (width-height) / 2.0, width - ((width-height) / 2.0));
    y = map(y, -1.75, 1, height, 0);
  }
}

// ===================================================
