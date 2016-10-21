package com.milkygames.androidsharing;
import android.app.Activity;
import android.content.Intent;
import android.net.Uri;

/**
 * Created by user on 03.11.2015.
 */
public class AndroidSharing {

    public static void ShareText(Activity activity,String text)
    {
        Intent shareIntent = new Intent();
        shareIntent.setAction(Intent.ACTION_SEND);
        shareIntent.putExtra(Intent.EXTRA_TEXT, text);
        shareIntent.setType("text/plain");
        shareIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        activity.getApplication().startActivity(shareIntent);
    }

    public static void ShareImageJPEG(Activity activity,String imagePath)
    {
        Intent shareIntent = new Intent();
        shareIntent.setAction(Intent.ACTION_SEND);
        Uri uriToImage = Uri.parse(imagePath);
        shareIntent.putExtra(Intent.EXTRA_STREAM, uriToImage);
        shareIntent.setType("image/jpeg");
        shareIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        activity.getApplication().startActivity(shareIntent);
    }

    public static void ShareImagePNG(Activity activity,String imagePath)
    {
        Intent shareIntent = new Intent();
        shareIntent.setAction(Intent.ACTION_SEND);
        Uri uriToImage = Uri.parse(imagePath);
        shareIntent.putExtra(Intent.EXTRA_STREAM, uriToImage);
        shareIntent.setType("image/png");
        shareIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        activity.getApplication().startActivity(shareIntent);
    }

    public static void ShareTextImageJPEG(Activity activity,String text,String imagePath)
    {
        Intent shareIntent = new Intent();
        shareIntent.setAction(Intent.ACTION_SEND);
        Uri uriToImage = Uri.parse(imagePath);
        shareIntent.putExtra(Intent.EXTRA_TEXT, text);
        shareIntent.putExtra(Intent.EXTRA_STREAM, uriToImage);
        shareIntent.setType("image/jpeg");
        shareIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        activity.getApplication().startActivity(shareIntent);
    }

    public static void ShareTextImagePNG(Activity activity,String text,String imagePath)
    {
        Intent shareIntent = new Intent();
        shareIntent.setAction(Intent.ACTION_SEND);
        Uri uriToImage = Uri.parse(imagePath);
        shareIntent.putExtra(Intent.EXTRA_TEXT, text);
        shareIntent.putExtra(Intent.EXTRA_STREAM, uriToImage);
        shareIntent.setType("image/png");
        shareIntent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
        activity.getApplication().startActivity(shareIntent);
    }

}
