# Changelog

### [1.1.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.5...v1.1.6) (2020-06-08)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.18.0 to 1.19.0 ([20194e4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/20194e4980f63bbad861072106e2e021f04fb07b))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.18.0 to 1.19.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.18.0...v1.19.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.4...v1.1.5) (2020-05-31)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.1 to 1.18.0 ([0007362](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/00073623aceece117ea477769b9ed8d45b3a16a0))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.1 to 1.18.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.1...v1.18.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.3...v1.1.4) (2020-05-24)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([8a22804](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8a228044dc5d526c45732ccf5a3eab26d1af1289))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.0.2 to 1.1.0. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.2...v1.1.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.2...v1.1.3) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.17.0 to 1.17.1 ([0e7b524](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/0e7b524ba889f2ff8eb254c603aa585ff7dac4ed))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.17.0 to 1.17.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.17.0...v1.17.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.1...v1.1.2) (2020-05-22)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.16.0 to 1.17.0 ([232231a](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/232231af22dc0338ce8f9b40c3cb88c3969ba3ef))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.16.0 to 1.17.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.16.0...v1.17.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.1.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.1.0...v1.1.1) (2020-04-21)

#### Bug Fixes

* **Prefabs:** allow teleport to same location as previous location ([b9ed929](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/b9ed9293aec99eabce9ad5fe887624a04e9983bd))
  > Zinnia 1.16.0 has some changes to the SurfaceLocator and the TransformPropertyApplier that allows both components to still operate if the previous location is the same as the current loaction.
  > 
  > This limitation in Zinnia 1.15.0 meant that you could not teleport to the same position that you were currently on, which was fine in most cases but there are some occasions where you do want to teleport back to where you're currently standing. This is now the default setting, but its still possible to switch the settings to have it work the way it did before.

## [1.1.0](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.6...v1.1.0) (2020-04-14)

#### Features

* **HowToGuides:** add guide for adding teleporter ([8e536a4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8e536a4f499de42d884dfd8870dadfd19b2dff8e))
  > added guided to demonstrate how to add a teleporter and to move around with the pointer.

#### Bug Fixes

* **HowToGuides:** add missing .meta files for guide ([ce62132](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/ce62132e9a81f7182f9d505c2e98a1b04d9e8528))
  > The Adding A Teleporter guide has no Unity meta files for any of the files within the guide. These have now been generated and added.

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.11.0 to 1.12.0 ([e3501e1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/e3501e10be53f04fe7addfb14d1a560f6de11213))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.11.0 to 1.12.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.11.0...v1.12.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.12.0 to 1.14.0 ([cf656e6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/cf656e6f4e5de7337fa0ff4db4ffeec7d72f6588))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.12.0 to 1.14.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.12.0...v1.14.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.14.0 to 1.14.1 ([f86060b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/f86060b58c9e48193c647be46b01005e37d998ab))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.0 to 1.14.1. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.0...v1.14.1)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>
* **deps:** bump io.extendreality.zinnia.unity from 1.14.1 to 1.15.0 ([6adc08c](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/6adc08c66684443ccebe9afb0dfeff1fd8ce64a1))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.14.1 to 1.15.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.14.1...v1.15.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.6](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.5...v1.0.6) (2020-01-02)

#### Bug Fixes

* **README.md:** provide correct URL for version release badge ([2e77507](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2e77507ca53128567ee806d13fa1ee6be29a28a3))
  > The URL in the version release badge was not valid and therefore the version number badge was not displaying.

### [1.0.5](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.4...v1.0.5) (2020-01-02)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.zinnia.unity from 1.9.0 to 1.11.0 ([8106a29](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/8106a2907565adaa5543515e0fcd21990ee99687))
  > Bumps [io.extendreality.zinnia.unity](https://github.com/ExtendRealityLtd/Zinnia.Unity) from 1.9.0 to 1.11.0. - [Release notes](https://github.com/ExtendRealityLtd/Zinnia.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Zinnia.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Zinnia.Unity/compare/v1.9.0...v1.11.0)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.4](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.3...v1.0.4) (2019-12-17)

#### Miscellaneous Chores

* **deps:** bump io.extendreality.tilia.utilities.shaders.unity ([c2c665b](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c2c665bd0213a7872fc1a2db42c7beef45bf2b02))
  > Bumps [io.extendreality.tilia.utilities.shaders.unity](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity) from 1.0.1 to 1.0.2. - [Release notes](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/releases) - [Changelog](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/blob/master/CHANGELOG.md) - [Commits](https://github.com/ExtendRealityLtd/Tilia.Utilities.Shaders.Unity/compare/v1.0.1...v1.0.2)
  > 
  > Signed-off-by: dependabot-preview[bot] <support@dependabot.com>

### [1.0.3](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.2...v1.0.3) (2019-12-16)

#### Bug Fixes

* **Scripts:** update namespace to correct tilia namespace ([7a87008](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/7a87008ba0160f9e09d846a19834a92a4adfaa41))
  > The code still had the VRTK.Prefabs namespace as it was copied over from the VRTK.Prefabs repo, this has now been updated to be in line with the Tilia repo name instead.

### [1.0.2](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.1...v1.0.2) (2019-12-16)

#### Bug Fixes

* **package.json:** provide correct version to shader dependency ([3a2bc9f](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/3a2bc9fa15508cf8503c37a8ce89c604991a8cd7))
  > The wrong shader package version was used due to an issue with the README on the shader repo displaying the wrong version. This has now been fixed by providing the correct version for the shader package dependency.

### [1.0.1](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/compare/v1.0.0...v1.0.1) (2019-12-16)

#### Bug Fixes

* **HowToGuides:** update incorrect package name ([c8efe03](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/c8efe039d6b0c1ad2cc7ed74bd3e0638d2ef32b2))
  > The package name was missing the tilia prefix and therefore was not correct and provided incorrect installation instructions.

## 1.0.0 (2019-12-16)

#### Features

* **structure:** create initial prefab and user guides ([2c9aab8](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/2c9aab8330d7ee1bfa81be5838d2a9060914c2d0))
  > The structure of the repository has been created with all the required files for the package, the prefab and the documentation.

#### Bug Fixes

* **package.json:** remove erroneous comma from dependencies ([e23a27c](https://github.com/ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity/commit/e23a27c589928122be2f7d62629add945dcc77ba))
  > There was an extra comma at the end of the dependencies causing the package.json to be invalid. It has now been removed.
