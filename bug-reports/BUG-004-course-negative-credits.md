# Bug Report

**Bug ID:** BUG-004  
**Title:** Course creation allows negative credit values  
**Feature:** Course Management (/Courses)  
**Severity:** High  
**Priority:** Medium  

## Description
The application allows users to create a course with negative credit values. This results in invalid course data and can impact GPA calculations and data integrity.

## Steps to Reproduce
1. Navigate to the Courses page  
2. Click "Add Course"  
3. Enter valid course name  
4. Enter credits: -3  
5. Submit the form  

## Expected Result
The application should:
- Reject negative credit values  
- Display a validation message  
- Prevent the course from being created  

## Actual Result
The course is successfully created with negative credits  

## Impact
- Allows invalid data entry  
- Can lead to incorrect GPA calculations  
- Reduces system reliability  

## Environment
- Browser: Chrome  
- OS: macOS  

## Screenshot
![BUG-004](../screenshots/BUG-004-negative-credits.png)