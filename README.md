
# react-native-design-system

## Getting started

`$ npm install @dino/react-native-design-system --save`

### Mostly automatic installation

`$ react-native link @dino/react-native-design-system`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `@dino/react-native-design-system` and add `RNDesignSystem.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNDesignSystem.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNDesignSystemPackage;` to the imports at the top of the file
  - Add `new RNDesignSystemPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':r@dino/react-native-design-system'
  	project(':@dino/react-native-design-system').projectDir = new File(rootProject.projectDir, 	'../node_modules/@dino/react-native-design-system/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':@dino/react-native-design-system')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNDesignSystem.sln` in `node_modules/@dino/react-native-design-system/windows/RNDesignSystem.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Design.System.RNDesignSystem;` to the usings at the top of the file
  - Add `new RNDesignSystemPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNDesignSystem from '@dino/react-native-design-system';

// TODO: What to do with the module?
RNDesignSystem;
```
  
