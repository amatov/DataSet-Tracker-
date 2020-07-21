###### **DataSet Tracker™**
###### openCV-based motion tracking software with real-time camera control and analysis using background subtraction and a watershed algorithm to select image features for tracking, coupled with a Lucas-Kanade optical flow display.
###### See a demo of the beta version developed in the cross-platform game engine Unity and designed to run on personal computers, smartphones and smart glasses hardware, and suitable for resource-constrained, on-the-fly computing in microscopes without internet connectivity at https://dsasof.com/synthetic-demo 
###### The video shows computer vision analysis of the motion of synthetic markers, which mimic live-cell fluorescent microscopy image sequences. Displacement vectors color-coding is used to show the angular direction as well as the speed of motion. A button selection allows changing the display preferences. The yellow vectors move to the right and are also shown in yellow within the right peak of the bi-modal histogram. Similarly, the vectors moving to the left are in red, both on the image overlay and within the left peak of the bi-modal histogram in the upper right corner of the screen. The second display option (not shown) changes the displacement vectors color-coding to showing different shades of green, depending on the speed. Observe on the unimodal histogram to the right showing that most of the particles move slower (the light-green peak to the left), while a few particles move very fast (the dark-green distribution tail on the right side). Real-time information on the frames per second analyzed, the average values for the speed and the angular vector orientations are displayed in the lower right corner of the screen. On the left side of the screen, there are sliders in the upper left corner, which allow to set the (i) the upper limit for the number of detected particles based on the a priori knowledge of the nature of the motion in the analyzed sample, (ii) the level of statistical significance for the particle selection step, i.e the level of particle detection stringency, (iii) the minimum distance between particles, which is another parameter selection done based on a priori knowledge of the type of sample analyzed, and (iv) a cut-off for the particle search radius, which limits the maximal allowed displacement; this is another parameter, which is selected based on a knowledge of the sample. By providing sample-specific input to the tracking module, the parameters selection allows to limit the computational complexity, to minimize the tracking errors and to deliver the fastest analysis results. The blue buttons in the lower-left corner of the screen allow to change various aspects of the screen display in terms of showing segmentation or tracking results, single-segment tracks (between just two frames) or the aggregated trajectories and, as described above, the vector color-coding (angles in red/yellow vs. speeds in different shades of green). 
