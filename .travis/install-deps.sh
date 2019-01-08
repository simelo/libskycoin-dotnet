#!/bin/bash

if [[ $TRAVIS_OS_NAME == 'linux' ]]; then
    wget -q https://packages.microsoft.com/config/ubuntu/16.04/packages-microsoft-prod.deb
    sudo apt-key adv --no-tty --keyserver hkp://keyserver.ubuntu.com:80 --recv-keys 3FA7E0328081BFF6A14DA29AA6A19B38D3D831EF
    sudo apt-get install apt-transport-https
    sudo echo "deb https://download.mono-project.com/repo/ubuntu wheezy/snapshots/$MONO_VERSION main" > /etc/apt/sources.list.d/mono-official-stable.list
    sudo dpkg -i packages-microsoft-prod.deb
    sudo apt-get update
#    sudo apt-get upgrade
    sudo apt-get install -y \
                 dotnet-sdk-2.1 \
                 mono-devel \
                 mono-complete \
                 referenceassemblies-pcl \
                 ca-certificates-mono \
                 msbuild
    mkdir swig_build && \
      cd swig_build && \
      wget http://prdownloads.sourceforge.net/swig/swig-3.0.12.tar.gz && \
      tar -zxf swig-3.0.12.tar.gz && \
      cd swig-3.0.12 && \
      sudo ./configure --prefix=/usr && \
      sudo make && sudo make install && \
      cd ../../ && \
      sudo rm -rf swig_build
fi

if [[ $TRAVIS_OS_NAME == 'osx' ]]; then
    curl -o MonoFramework-MDK-4.8.0.524.macos10.xamarin.universal.pkg https://download.mono-project.com/archive/4.8.0/macos-10-universal/MonoFramework-MDK-4.8.0.524.macos10.xamarin.universal.pkg
    curl -o dotnet-sdk-2.1.500-osx-gs-x64.pkg https://download.visualstudio.microsoft.com/download/pr/576dbb8d-03f2-4d45-857a-b226d39b3dbe/0d4fbf91aa1137352680ec98ef9edb5d/dotnet-sdk-2.1.500-osx-gs-x64.pkg
    sudo installer -pkg MonoFramework-MDK-4.8.0.524.macos10.xamarin.universal.pkg -target /
    sudo installer -pkg dotnet-sdk-2.1.500-osx-gs-x64.pkg -target /

    ruby -e "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/master/install)" < /dev/null 2> /dev/null
    brew install swig
    brew install gimme
fi

if [ "$DOTNETCORE" != "" ]; then
    mkdir ./.travis/bin
    curl -o ./.travis/bin/nuget.exe https://dist.nuget.org/win-x86-commandline/latest/nuget.exe
fi
