//
//  File.m
//  NativeSharing_iOS
//
//  Created by sorrowful on 05.11.15.
//  Copyright © 2015 sorrowful. All rights reserved.
//

#import <Foundation/Foundation.h>
#include <UIKit/UIKit.h>
extern "C"
{
    NSString * ParseiOSString(const char * cString)
    {
        return [[NSString alloc] initWithUTF8String:cString];
    }
    
    UIImage * LoadImage(const char * imagePath)
    {
        return [UIImage imageWithContentsOfFile:ParseiOSString(imagePath)];
    }
    
    UIActivityViewController * CreateShareUI(NSArray * shareItems)
    {
        return [[UIActivityViewController alloc]initWithActivityItems:shareItems applicationActivities:nil];
    }
    
    void ShowShareUI(UIActivityViewController * ui)
    {
        UIViewController * root = [[[UIApplication sharedApplication] keyWindow] rootViewController];
        //if iphone
        if (UI_USER_INTERFACE_IDIOM() == UIUserInterfaceIdiomPhone) {
            [root presentViewController:ui animated:YES completion:nil];
        }
        //if iPad
        else {
            // Change Rect to position Popover
            UIPopoverController *popup = [[UIPopoverController alloc] initWithContentViewController:ui];
            [popup presentPopoverFromRect:CGRectMake(root.view.frame.size.width/2, root.view.frame.size.height/4, 0, 0)inView:root.view permittedArrowDirections:UIPopoverArrowDirectionAny animated:YES];
        }
        
    }
    
    void CreateAndShowShareUI(NSArray * shareItems)
    {
        ShowShareUI(CreateShareUI(shareItems));
    }
    
    void ShareText(const char * text)
    {
        CreateAndShowShareUI(@[ParseiOSString(text)]);
    }
    
    void ShareImage(const char * imagePath)
    {
        CreateAndShowShareUI(@[LoadImage(imagePath)]);
    }
    
    void ShareTextAndImage(const char * text,const char* imagePath)
    {
        CreateAndShowShareUI(@[ParseiOSString(text),LoadImage(imagePath)]);
    }   
    
}
