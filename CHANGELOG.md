# Changelog

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
