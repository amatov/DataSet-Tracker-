using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnity;

public class TracerData {

	//Data Class to store parameters
	public Point mPt;
	public Point mPt2;
	public Scalar mHue;
	public Scalar mNew;
	public long mFrame;
	public float mAngle;
	public float mSpeed;
	public bool mBoolS;

	//Constructors
	public TracerData (Point Pt, Point Pt2, Scalar Hue, Scalar New, long Frame, float Angle, float Speed){

		mPt = Pt;
		mPt2 = Pt2;
		mHue = Hue;
		mNew = New;
		mFrame = Frame;
		mAngle = Angle;
		mSpeed = Speed;
		//mBoolS = BoolS;

	}



//	public string GetDataForObj(){
//
//		return myCSVData;
//	}
		

	 
}
